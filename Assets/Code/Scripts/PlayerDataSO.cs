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

[CreateAssetMenu(fileName = "New Player Data", menuName = "CptLost/Player Data")]
public class PlayerDataSO : ScriptableObject
{
    public BigDouble points = 0;
    public List<UpgradeStorageData> upgrades = new List<UpgradeStorageData>();
}
