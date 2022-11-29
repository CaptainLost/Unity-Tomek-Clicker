using BreakInfinity;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrinterUpgradeLogic : UpgradeLogic
{
    protected override void Tick()
    {
        foreach (PrinterStorageData storageData in DataManager.Instance.PlayerData.PrinterData.SlotData)
        {
            PrinterTick(storageData);
        }

        VisualManager.Instance.UpdatePrinters();
    }

    public override BigDouble CalulateClickPoints()
    {
        return 0;
    }

    public override BigDouble CalculateTickPoints()
    {
        return 0;
    }

    private void PrinterTick(PrinterStorageData storageData)
    {
        ManagePrinterTemperature(storageData);
        ManagePrinterPrint(storageData);
    }

    private void ManagePrinterTemperature(PrinterStorageData storageData)
    {

    }

    private void ManagePrinterPrint(PrinterStorageData storageData)
    {
        if (storageData.CurrentInk <= 0)
        {
            // Turn off here?

            return;
        }

        if (storageData.IsOverheated)
        {
            storageData.PrintProgress = 0f;

            return;
        }

        storageData.PrintProgress += storageData.PrinterType.ProgressPerSpeedLevel * storageData.SpeedLevel;

        if (storageData.PrintProgress > 100f)
        {
            storageData.PrintProgress = 0f;

            DoPrint(storageData);
        }

        ManageInk(storageData);
    }

    private void ManageInk(PrinterStorageData storageData)
    {
        storageData.CurrentInk -= storageData.PrinterType.InkConsumptionPerTick;

        float maxInk = storageData.PrinterType.InkPerLevel * storageData.InkLevel;
        storageData.CurrentInk = Mathf.Clamp(storageData.CurrentInk, 0f, maxInk);
    }

    private void DoPrint(PrinterStorageData storageData)
    {
        DataManager.Instance.AddPoints(storageData.PrinterType.RewardPerPrint);
    }
}
