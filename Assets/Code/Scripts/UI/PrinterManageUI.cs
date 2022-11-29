using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrinterManageUI : MonoBehaviour
{
    [SerializeField] private PrinterSlotUI holdingSlot;
    [SerializeField] private PrinterSetVisualUI visualSet;

    [SerializeField] private PrinterUpgradeVisualUI upgradeVisual;
    [SerializeField] private PrinterBarVisualUI barVisual;

    public void UpdateUI()
    {
        visualSet.Set(holdingSlot.StorageData.PrinterType);
        upgradeVisual.UpdateUpgrade(holdingSlot.StorageData);
        barVisual.UpdateBars(holdingSlot.StorageData);
    }

    public void BuySpeedUpgrade()
    {
        PrinterManager.BuyPrinterSpeedUpgrade(holdingSlot.StorageData);
    }

    public void BuyInkUpgrade()
    {
        PrinterManager.AddPrinterInkUpgrade(holdingSlot.StorageData);
    }

    public void BuyCoolingUpgrade()
    {
        PrinterManager.AddPrinterCoolingUpgrade(holdingSlot.StorageData);
    }

    public void BuyInkRefill()
    {
        if (PrinterManager.PrinterHasMaxInk(holdingSlot.StorageData))
            return;

        if (DataManager.Instance.HasPoints(holdingSlot.StorageData.PrinterType.CostPerInkRefill))
        {
            PrinterManager.RefillPrinterInk(holdingSlot.StorageData);
            DataManager.Instance.RemovePoints(holdingSlot.StorageData.PrinterType.CostPerInkRefill);
        }
    }
}
