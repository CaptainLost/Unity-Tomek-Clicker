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

[CreateAssetMenu(fileName = "New Player Data", menuName = "CptLost/Data/Player Data")]
public class PlayerDataSO : ScriptableObject
{
    [Header("Points")]
    [SerializeField] public BigDouble points = 0;
    public BigDouble highestAmountOfPoints = 0;

    [SerializeReference] public List<UpgradeStorageData> upgradesData = new List<UpgradeStorageData>();
    [field: SerializeField] public PrinterDataSO PrinterData { get; private set; }

    public void UpdateHighestAmountOfPoints()
    {
        if (points > highestAmountOfPoints)
        {
            highestAmountOfPoints = points;
        }
    }
}
