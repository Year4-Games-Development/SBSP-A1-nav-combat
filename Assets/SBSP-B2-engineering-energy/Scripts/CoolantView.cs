using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoolantView : MonoBehaviour
{
    public CoolantController coolController;

    void Awake()
    {
        coolController = new CoolantController();

    }

    void FixedUpdate() {}

    void Update()
    {
        coolController.CoolantTypeBeingUsed();
        coolController.CoolantNeededCalc();
        coolController.RetrieveCoolantFromTempStores();
        coolController.CoolantTempStroageInfo();
    }
  
    void OnGUI()
    {
        // All text outputs are actual outputs, if needed, use the code to collect the outputs.
        GUI.Label(new Rect(100, 15, 200, 40), "CoolantAvailable: " + coolController.TempStorage.AvailableCoolant);
        GUI.Label(new Rect(100, 35, 200, 40), "CoolantType: " + coolController.Coolant.CoolantType);
        GUI.Label(new Rect(100, 55, 200, 40), "Storage Capacity: " + coolController.TempStorage.StorageMaxCapacity);
        GUI.Label(new Rect(100, 75, 200, 40), "Storage At Max: " + coolController.TempStorage.StorageAtMaxCapacity);
        GUI.Label(new Rect(100, 95, 200, 40), "Storage Empty: " + coolController.TempStorage.StorageEmpty);
        GUI.Label(new Rect(100, 115, 200, 40), "Pump Type: " + coolController.CoolantPump.PumpType);
        GUI.Label(new Rect(100, 135, 200, 40), "Coolant Ready: " + coolController.TempStorage.CoolantReady);
        GUI.Label(new Rect(100, 155, 200, 40), "Coolant Needed Flag: " + coolController.TempStorage.CoolantNeeded);
        GUI.Label(new Rect(100, 175, 200, 40), "Coolant Package: " + coolController.TempStorage.CoolantPackage);
    }
}
