using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BreakInfinity;

public static class UpgradeHelper
{
    public static BigDouble CalculatePrice(UpgradeSO upgradeData, int level)
    {
        return upgradeData.BasePrice * BigDouble.Pow(upgradeData.PriceModifier, level);
    }

    public static BigDouble CalculatePrice(UpgradeSO upgradeData)
    {
        return CalculatePrice(upgradeData, DataManager.Instance.GetAmountOfUpgrade(upgradeData) + 1);
    }

    public static BigDouble CalculateReceivedPointsFromUpgrade(UpgradeSO upgradeData, int currentLevel)
    {
        return upgradeData.BasePoints * currentLevel;
    }

    public static BigDouble CalculateReceivedPointsFromUpgrade(UpgradeSO upgradeData)
    {
        return CalculateReceivedPointsFromUpgrade(upgradeData, DataManager.Instance.GetAmountOfUpgrade(upgradeData));
    }

    public static BigDouble CalculatePointsPerSecond()
    {
        BigDouble pointsPerSecond = 0;

        for (int i = 0; i < DataManager.Instance.UpgradeData.Upgrades.Count; i++)
        {
            UpgradeSO upgradeData = DataManager.Instance.UpgradeData.Upgrades[i];

            pointsPerSecond += CalculateReceivedPointsFromUpgrade(upgradeData);
        }

        return pointsPerSecond;
    }

    public static BigDouble CalculateClickBonusFromUpgrade(UpgradeSO upgradeData, int currentLevel)
    {
        return upgradeData.ClickBonusPoints * currentLevel;
    }

    public static BigDouble CalculateClickBonusFromUpgrade(UpgradeSO upgradeData)
    {
        return CalculateClickBonusFromUpgrade(upgradeData, DataManager.Instance.GetAmountOfUpgrade(upgradeData));
    }

    public static BigDouble CalculateBonusClickPoints()
    {
        BigDouble bonusPoints = 0;

        for (int i = 0; i < DataManager.Instance.UpgradeData.Upgrades.Count; i++)
        {
            UpgradeSO upgradeData = DataManager.Instance.UpgradeData.Upgrades[i];

            bonusPoints += CalculateClickBonusFromUpgrade(upgradeData);
        }

        return bonusPoints;
    }
}
