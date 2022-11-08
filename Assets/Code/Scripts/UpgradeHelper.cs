using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BreakInfinity;

public static class UpgradeHelper
{
    public static BigDouble CalculatePrice(UpgradeSO upgradeData, int level)
    {
        return upgradeData.CalculatePrice(level);
    }

    public static BigDouble CalculatePrice(UpgradeSO upgradeData)
    {
        return CalculatePrice(upgradeData, DataManager.Instance.GetAmountOfUpgrade(upgradeData) + 1);
    }
}
