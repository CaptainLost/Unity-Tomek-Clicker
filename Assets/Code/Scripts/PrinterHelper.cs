using BreakInfinity;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//TODO TO REWORK
public static class PrinterHelper
{
    public static BigDouble CalulateInkLevelPrice(PrinterUpgradeSO printerData, int level)
    {
        return printerData.BaseInkPrice * Mathf.Pow(printerData.InkPriceModifier, level);
    }

    public static BigDouble CalulateInkLevelPrice(PrinterUpgradeSO printerData)
    {
        return CalulateInkLevelPrice(printerData, DataManager.Instance.GetAmountOfUpgrade(printerData) + 1);
    }

    public static BigDouble CalulateSpeedLevelPrice(PrinterUpgradeSO printerData, int level)
    {
        return printerData.BaseSpeedPrice * Mathf.Pow(printerData.SpeedPriceModifier, level);
    }

    public static BigDouble CalulateSpeedLevelPrice(PrinterUpgradeSO printerData)
    {
        return CalulateSpeedLevelPrice(printerData, DataManager.Instance.GetAmountOfUpgrade(printerData) + 1);
    }

    public static BigDouble CalulateCoolingLevelPrice(PrinterUpgradeSO printerData, int level)
    {
        return printerData.BaseCoolingPrice * Mathf.Pow(printerData.CoolingPriceModifier, level);
    }

    public static BigDouble CalulateCoolingLevelPrice(PrinterUpgradeSO printerData)
    {
        return CalulateSpeedLevelPrice(printerData, DataManager.Instance.GetAmountOfUpgrade(printerData) + 1);
    }

    public static bool BuyPrinterSpeedLevel(PrinterUpgradeSO printerData, int amount) //TODO buy multiplie upgrades
    {
        PrinterStorageData storageData = DataManager.Instance.GetUpgradeData(printerData) as PrinterStorageData;

        if (storageData == null)
            return false;

        if (storageData.currentSpeedLevel >= printerData.MaxSpeedLevel)
            return false;

        BigDouble price = CalulateSpeedLevelPrice(printerData);

        if (!DataManager.Instance.HasPoints(price))
            return false;

        storageData.currentSpeedLevel += 1;

        DataManager.Instance.RemovePoints(price);

        VisualManager.Instance.UpdatePrinterUpgrades();

        return true;
    }

    public static bool BuyPrinterInkLevel(PrinterUpgradeSO printerData, int amount) //TODO buy multiplie upgrades
    {
        PrinterStorageData storageData = DataManager.Instance.GetUpgradeData(printerData) as PrinterStorageData;

        if (storageData == null)
            return false;

        if (storageData.currentInkLevel >= printerData.MaxInkLevel)
            return false;

        BigDouble price = CalulateInkLevelPrice(printerData);

        if (!DataManager.Instance.HasPoints(price))
            return false;

        storageData.currentInkLevel += 1;

        DataManager.Instance.RemovePoints(price);

        VisualManager.Instance.UpdatePrinterUpgrades();

        return true;
    }

    public static bool BuyPrinterCoolingLevel(PrinterUpgradeSO printerData, int amount) //TODO buy multiplie upgrades
    {
        PrinterStorageData storageData = DataManager.Instance.GetUpgradeData(printerData) as PrinterStorageData;

        if (storageData == null)
            return false;

        if (storageData.currentCoolingLevel >= printerData.MaxCoolingLevel)
            return false;

        BigDouble price = CalulateCoolingLevelPrice(printerData);

        if (!DataManager.Instance.HasPoints(price))
            return false;

        storageData.currentCoolingLevel += 1;

        DataManager.Instance.RemovePoints(price);

        VisualManager.Instance.UpdatePrinterUpgrades();

        return true;
    }
}
