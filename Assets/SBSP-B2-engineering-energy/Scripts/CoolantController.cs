using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoolantController
{
    private const string BASE_COOLANT = "Water";
    private const float COOLANT_PACKAGE_NUM = 50f; // NOTE: what is this?
    private const float STARTING_COOLANT = 1000f;
    private const string COOLANT_PUMP_TYPE = "Class1";

    private CoolantModel coolant = new CoolantModel(BASE_COOLANT);
    public CoolantModel Coolant { get { return coolant; } }

    private CoolantTempStorageModel tempStorage = new CoolantTempStorageModel(BASE_COOLANT, STARTING_COOLANT, STARTING_COOLANT, false, false, 0f);
    public CoolantTempStorageModel TempStorage { get { return tempStorage; } }

    private CoolantPumpModel coolantPump = new CoolantPumpModel(COOLANT_PUMP_TYPE, 1f, 1f);
    public CoolantPumpModel CoolantPump { get { return coolantPump; } }

    private bool coolantPackageFlag = false;
    public bool CoolantPackageFlag { get { return coolantPackageFlag; } set { coolantPackageFlag = value; } }

    //To be decide by consumers
    private  bool coolantFlag = false;
    public bool CoolantFlag { get { return coolantFlag; } set { coolantFlag = value; } }

    private float neededCoolant;
    public float NeededCoolant { get { return neededCoolant; } set { neededCoolant = value; } }

    public void CoolantTypeBeingUsed()
    {
        tempStorage.CoolantType = coolant.CoolantType;
    }

    public void CoolantTempStroageInfo()//Storage MaxCapacity set too 1000f. Available coolant info. Max capacity bool depending on coolant level.
    {
        float storageMaxCap = tempStorage.StorageMaxCapacity;
        float availCoolant = tempStorage.AvailableCoolant;

        tempStorage.StorageAtMaxCapacity = (availCoolant == storageMaxCap);
    }

    public void CoolantNeededCalc()
    {//coolantNeededFlag will allow the method to run once in update,this will stop a constant minus of stored coolant
       // tempStorage.SetCoolantNeeded(coolantFlag);
        // bool coolantNeededFlag = tempStorage.GetCoolantNeeded();
   
        if (tempStorage.CoolantNeeded)
        {
            float coolantRemaining = tempStorage.AvailableCoolant - neededCoolant;
            tempStorage.AvailableCoolant = coolantRemaining;
            tempStorage.CoolantNeeded = false;
        }
    }

    public void RetrieveCoolantFromTempStores()
    {
        bool storageAtMax = tempStorage.StorageAtMaxCapacity;
        float availableCoolant = tempStorage.AvailableCoolant;
        bool coolantReady = tempStorage.CoolantReady;
        float coolantPackage = tempStorage.CoolantPackage;

        if (tempStorage.AvailableCoolant <= 0f)
        {
            tempStorage.AvailableCoolant = 0f;
            tempStorage.StorageEmpty = true;
        }
        else
        {

            if (neededCoolant > 0 && coolantPackageFlag)
            {   //coolantPackageFlag will allow this part of the method to run once at a time in update, 
              
                neededCoolant -= 1.0f;
                float newPackage = coolantPackage += 1.0f;
                tempStorage.CoolantPackage = newPackage;
              

                if (coolantPackage >= COOLANT_PACKAGE_NUM)
                {
                    tempStorage.CoolantReady = true;
                    coolantPackageFlag = false;
                    //Call GetCoolantPackage to retrieve 50f or coolant for consumers- Change to suit yourself
                }//Change method as you want if you dont want to use packages, just a slow stream is optional.
            }//Also can add Delta time, for a cooldown
            tempStorage.StorageEmpty = false;
        }
    }
}
