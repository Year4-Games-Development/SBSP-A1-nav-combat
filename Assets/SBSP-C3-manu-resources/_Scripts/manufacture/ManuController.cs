﻿using UnityEngine;
using UnityEngine.UI;

public class ManuController : MonoBehaviour
{
    public Text itemName;
    public Text description;
    public Button button;
    public Text cost;

    private ManuModel _manuModel;
    private ManuView _manuView;
    [SerializeField]
    private InventoryManager _inventoryManager;

    public InventoryManager InventoryManager
    {
        get
        {
            return _inventoryManager;
        }

        set
        {
            _inventoryManager = value;
        }
    }

    void Awake()
    {
        _manuModel = new ManuModel(itemName, description, button, cost);
    }

    public ManuModel GetManuModel()
    {
        return _manuModel;
    }

    public void Manufactureing()
    {
        Debug.Log("product being manufactured");

        if (_manuModel.GetManufacture().GetName() == "Fuel")
        {
            InventoryManager.AddItem(ItemFactory.instance.CreateItem(ItemType.Fuel));
            InventoryManager.RemoveItem(ItemType.Gold);
            Debug.Log("Manufacturing:" + _manuModel.GetManufacture().GetName());
        }
        
        if (_manuModel.GetManufacture().GetName() == "Ammo")
        {
            InventoryManager.AddItem(ItemFactory.instance.CreateItem(ItemType.Ammo));
            InventoryManager.RemoveItem(ItemType.Gold);
            Debug.Log("Manufacturing:" + _manuModel.GetManufacture().GetName());
        }

        if (_manuModel.GetManufacture().GetName() == "Search Droid")
        {
            InventoryManager.AddItem(DroidFactory.instance.CreateDroid(DroidType.SearchDroid));
            InventoryManager.RemoveItem(ItemType.Gold);
            Debug.Log("Manufacturing:" + _manuModel.GetManufacture().GetName());
        }

        if (_manuModel.GetManufacture().GetName() == "Repair Droid")
        {
            InventoryManager.AddItem(DroidFactory.instance.CreateDroid(DroidType.RepairDroid));
            InventoryManager.RemoveItem(ItemType.Gold);
            Debug.Log("Manufacturing:" + _manuModel.GetManufacture().GetName());
        }
    }
}
