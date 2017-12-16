using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CoolantModel 
{
    private string coolantType = "";
    public string CoolantType { get { return coolantType; } set { coolantType = value; } }

    public CoolantModel() { }

    public CoolantModel(string coolantType)
    {
        this.coolantType = coolantType;
    }
}

