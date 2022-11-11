using BreakInfinity;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrinterUpgradeLogic : UpgradeLogic
{
    [SerializeField] private float maxTemperatureStep = 2f;

    protected override void Tick()
    {
        PrinterUpgradeSO printerUpgrade = upgrade as PrinterUpgradeSO;

        if (printerUpgrade == null)
            return;

        PrinterStorageData storageData = DataManager.Instance.GetUpgradeData(printerUpgrade) as PrinterStorageData;

        if (storageData == null)
            return;

        ManageTemperature(printerUpgrade, storageData);

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

    //private void ManageTemperature(PrinterUpgradeSO printerUpgrade, PrinterStorageData storageData)
    //{
    //    float speedFactor = Mathf.Clamp(storageData.currentSpeedLevel / printerUpgrade.MaxSpeedLevel, 0f, 1f);
    //    float coolingFactor = Mathf.Clamp(storageData.currentCoolingLevel / printerUpgrade.MaxCoolingLevel, 0f, 1f);

    //    speedFactor *= 0.8f;

    //    float newTemperature = storageData.currentTemperature;

    //    float changeFactor = speedFactor - coolingFactor; // From -1 to 1

    //    if (changeFactor == 0f) // If zero lower temperature by minimum
    //        changeFactor = -1f / printerUpgrade.MaxCoolingLevel;

    //    float lowTemperature = Random.Range(printerUpgrade.MinTemperature, printerUpgrade.MinTemperature + maxOrbitValue);
    //    float highTemperature = Random.Range(printerUpgrade.MaxTemperature - maxOrbitValue, printerUpgrade.MaxTemperature);

    //    float targetTemperature = changeFactor.Remap(-1, 1, lowTemperature, highTemperature);

    //    newTemperature = Mathf.MoveTowards(newTemperature, targetTemperature, Mathf.Abs(changeFactor) * maxTemperatureStep);

    //    storageData.currentTemperature = Mathf.Clamp(newTemperature, printerUpgrade.MinTemperature, printerUpgrade.MaxTemperature);

    //    Debug.Log($"T {targetTemperature} SF {speedFactor} CF {coolingFactor} CFF {changeFactor}");
    //}

    private void ManageTemperature(PrinterUpgradeSO printerUpgrade, PrinterStorageData storageData)
    {
        float speedFactor = Mathf.Clamp(storageData.currentSpeedLevel / printerUpgrade.MaxSpeedLevel, 0f, 1f);
        float coolingFactor = Mathf.Clamp(storageData.currentCoolingLevel / printerUpgrade.MaxCoolingLevel, 0f, 1f);

        float newTemperature = storageData.currentTemperature;

        if (Mathf.Abs(speedFactor - coolingFactor) <= 0.1f)
        {

        }
        else if (speedFactor > coolingFactor) // Heating
        {

        }
        else if (speedFactor < coolingFactor) // Cooling
        {

        }
    }
}
