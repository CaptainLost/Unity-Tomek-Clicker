using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrinterManageUI : MonoBehaviour
{
    [SerializeField] private PrinterSlotUI holdingSlot;
    [SerializeField] private PrinterSetVisualUI visualSet;

    private void Start()
    {
        
    }

    public void UpdateUI()
    {
        visualSet.Set(holdingSlot.StorageData.PrinterType);
    }

    public void BuySpeedUpgrade()
    {
        PrinterManager.Instance.BuyPrinterSpeedUpgrade(holdingSlot.StorageData);
    }
}
