using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoolantTempStorageModel 
{
    private string coolantType;
    public string CoolantType { get { return coolantType; } set { coolantType = value; } }

    private float availableCoolant;
    public float AvailableCoolant { get { return availableCoolant; } set { availableCoolant = value; } }

    private float storageMaxCapacity;
    public float StorageMaxCapacity { get { return storageMaxCapacity; } set { storageMaxCapacity = value; } }

    private float coolantPackage;
    public float CoolantPackage { get { return coolantPackage; } set { coolantPackage = value; } }

    private bool storageEmpty;
    public bool StorageEmpty { get { return storageEmpty; } set { storageEmpty = value; } }

    private bool storageAtMaxCapacity;
    public bool StorageAtMaxCapacity { get { return storageAtMaxCapacity; } set { storageAtMaxCapacity = value; } }

    private bool coolantReady;
    public bool CoolantReady { get { return coolantReady; } set { coolantReady = value; } }

    private bool coolantNeeded;
    public bool CoolantNeeded { get { return coolantNeeded; } set { coolantNeeded = value; } }


    public CoolantTempStorageModel()
    {
        coolantType = "";
        availableCoolant =0.0f;
        storageMaxCapacity = 0.0f;
        storageAtMaxCapacity = false;
        storageEmpty = false;
        coolantReady = false;
        coolantNeeded = false;
        coolantPackage = 0.0f;

    }

    public CoolantTempStorageModel(string coolantType, float availableCoolant, float storageMaxCapacity, 
        bool coolantReady, bool coolantNeeded, float coolantPackage)
    {
        this.coolantType = coolantType;
        this.availableCoolant = availableCoolant;
        this.storageMaxCapacity = storageMaxCapacity;
        this.coolantReady = coolantReady;
        this.coolantNeeded = coolantNeeded;
        this.coolantPackage = coolantPackage;

        storageAtMaxCapacity = availableCoolant == storageMaxCapacity;
        storageEmpty = availableCoolant == 0f;
    }
}
