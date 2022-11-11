using BreakInfinity;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class UpgradeStorageData
{
    public UpgradeStorageData(UpgradeSO _upgrade, int _amount)
    {
        upgrade = _upgrade;
        amount = _amount;
    }

    public UpgradeSO upgrade;
    public int amount;
}

<<<<<<< Updated upstream:Assets/Code/Scripts/PlayerDataSO.cs
[CreateAssetMenu(fileName = "New Player Data", menuName = "CptLost/Player Data")]
public class PlayerDataSO : ScriptableObject
{
    public BigDouble points = 0;
    public List<UpgradeStorageData> upgrades = new List<UpgradeStorageData>();
=======
[Serializable]
public class PrinterStorageData : UpgradeStorageData
{
    public PrinterStorageData(PrinterUpgradeSO _upgrade, int _amount)
        : base(_upgrade, _amount)
    {

    }

    public float currentInkAmount = 1f;
    public float currentTemperature = 20f; // 0 - 1
    public float currentPrintProgress = 0f;

    public int currentInkLevel = 0;
    public int currentSpeedLevel = 0;
    public int currentCoolingLevel = 0;
}

[CreateAssetMenu(fileName = "New Player Data", menuName = "CptLost/Data/Player Data")]
public class PlayerDataSO : ScriptableObject
{
    [Header("Points")]
    public BigDouble currentPoints = 0;
    public BigDouble highestAmountOfPoints = 0;

    [Header("Upgrades")]
    [SerializeReference] public List<UpgradeStorageData> upgradesData = new List<UpgradeStorageData>();
    [SerializeField] private PlayerPrinterDataSO printerData;

    public void UpdateHighestAmountOfPoints()
    {
        if (currentPoints > highestAmountOfPoints)
        {
            highestAmountOfPoints = currentPoints;
        }
    }
>>>>>>> Stashed changes:Assets/Code/Scripts/Player Data/PlayerDataSO.cs
}
