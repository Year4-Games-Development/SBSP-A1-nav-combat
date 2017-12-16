using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoolantPumpModel
{

    private string pumpType;
    public string PumpType { get { return pumpType; } set { pumpType = value; } }

    private float deliverySpeedMultiplier;
    public float DelierySpeedMultiplier { get { return deliverySpeedMultiplier; } set { DelierySpeedMultiplier = value; } }

    private float deliverySpeed;
    public float DeliverySpeed { get { return deliverySpeed; } set { deliverySpeed = value; } }

    public CoolantPumpModel()
    {
        pumpType = "";
        deliverySpeed = 0.0f;
        deliverySpeedMultiplier = 0.0f;
    }

    public CoolantPumpModel(string pumpType, float deliverySpeed, float deliverySpeedMultiplier)
    {
        this.pumpType = pumpType;
        this.deliverySpeed = deliverySpeed;
        this.deliverySpeedMultiplier = deliverySpeedMultiplier;
    }
}
