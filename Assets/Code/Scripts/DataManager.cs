using BreakInfinity;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DataManager : MonoBehaviour
{
    public static DataManager Instance;

    [SerializeField] private UpgradeDataSO upgradeData;
    [SerializeField] private PlayerDataSO playerData;

    [SerializeField] private UnityEvent onPointsAdded = new UnityEvent();
    [SerializeField] private UnityEvent onPointsRemoved = new UnityEvent();
    [SerializeField] private UnityEvent onUpgradeAdded = new UnityEvent();
    [SerializeField] private UnityEvent onUpgradeRemoved = new UnityEvent();

    public PlayerDataSO PlayerData { get { return playerData; } }
    public UpgradeDataSO UpgradeData { get { return upgradeData; } }

<<<<<<< Updated upstream
=======
    public BigDouble Points { get { return playerData.currentPoints; } }
    public BigDouble HighestAmountOfPoints { get { return playerData.highestAmountOfPoints; } }

>>>>>>> Stashed changes
    private void Awake()
    {
        Instance = this;
    }

    public void AddPoints(BigDouble points)
    {
        playerData.currentPoints += points;

        onPointsAdded?.Invoke();
    }

    public void RemovePoints(BigDouble points)
    {
        playerData.currentPoints -= points;

        if (playerData.points < 0)
            playerData.points = 0;

        onPointsRemoved?.Invoke();
    }

    public void SetPoints(BigDouble points)
    {
<<<<<<< Updated upstream
        playerData.points = points;
=======
        playerData.currentPoints = points;

        playerData.UpdateHighestAmountOfPoints();
>>>>>>> Stashed changes
    }

    public bool HasPoints(BigDouble points)
    {
        return playerData.currentPoints >= points;
    }

    public BigDouble GetPoints()
    {
        return playerData.points;
    }

    public UpgradeStorageData GetUpgradeData(UpgradeSO requestedData)
    {
        foreach (UpgradeStorageData data in playerData.upgrades)
        {
            if (data.upgrade == requestedData)
            {
                return data;
            }
        }

        UpgradeStorageData newData = new UpgradeStorageData(requestedData, 0);
        playerData.upgrades.Add(newData);

        return newData;
    }

    public void AddUpgrade(UpgradeSO upgradeData, int amount)
    {
        UpgradeStorageData data = GetUpgradeData(upgradeData);

        data.amount = data.amount + amount;

        onUpgradeAdded?.Invoke();
    }

    public void RemoveUpgrade(UpgradeSO upgradeData, int amount)
    {
        UpgradeStorageData data = GetUpgradeData(upgradeData);

        data.amount = data.amount - amount;

        onUpgradeRemoved?.Invoke();
    }

    public int GetAmountOfUpgrade(UpgradeSO upgradeData)
    {
        UpgradeStorageData data = GetUpgradeData(upgradeData);

        return data.amount;
    }

    public bool BuyUpgrade(UpgradeSO upgradeData)
    {
        BigDouble price = UpgradeHelper.CalculatePrice(upgradeData);

        if (GetAmountOfUpgrade(upgradeData) < upgradeData.MaxAmount && HasPoints(price))
        {
            RemovePoints(price);
            AddUpgrade(upgradeData, 1);

            return true;
        }

        return false;
    }
}
