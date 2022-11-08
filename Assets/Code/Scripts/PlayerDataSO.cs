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

[Serializable]
public class PrinterStorageData : UpgradeStorageData
{
    public PrinterStorageData(PrinterUpgradeSO _upgrade, int _amount)
        : base(_upgrade, _amount)
    {

    }

    public float currentInkAmount = 1f;
    public float currentPrintProgress = 0f;
}

[CreateAssetMenu(fileName = "New Player Data", menuName = "CptLost/Player Data")]
public class PlayerDataSO : ScriptableObject
{
    public BigDouble points = 0;
    [SerializeReference] public List<UpgradeStorageData> upgradesData = new List<UpgradeStorageData>();

    public BigDouble highestAmountOfPoints = 0;

    public void UpdateHighestAmountOfPoints()
    {
        if (points > highestAmountOfPoints)
        {
            highestAmountOfPoints = points;
        }
    }
}
