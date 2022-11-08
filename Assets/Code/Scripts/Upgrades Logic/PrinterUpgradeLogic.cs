using BreakInfinity;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrinterUpgradeLogic : UpgradeLogic
{
    protected override void Tick()
    {
        PrinterUpgradeSO printerUpgrade = upgrade as PrinterUpgradeSO;

        if (printerUpgrade == null)
            return;

        PrinterStorageData storageData = DataManager.Instance.GetUpgradeData(printerUpgrade) as PrinterStorageData;

        if (storageData == null)
            return;

        storageData.currentPrintProgress += printerUpgrade.BasePrintAmount;

        if (storageData.currentPrintProgress >= printerUpgrade.NeededPrintAmount)
        {
            storageData.currentPrintProgress = 0f;
        }

        VisualManager.Instance.UpdatePrinterUpgrades();
    }

    public override BigDouble CalculateTickPoints()
    {
        PrinterUpgradeSO printerUpgrade = upgrade as PrinterUpgradeSO;

        if (printerUpgrade == null)
            return 0;

        return 0;
    }

    public override BigDouble CalulateClickPoints()
    {
        return 0;
    }
}
