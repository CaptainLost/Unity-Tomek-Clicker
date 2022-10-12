using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataManager : MonoBehaviour
{
    public static DataManager Instance;

    [SerializeField] private UpgradeDataSO upgradeData;

    private Dictionary<UpgradeSO, int> upgradeIndexes = new Dictionary<UpgradeSO, int>();

    public PlayerData PlayerData { get { return playerData; } }
    public UpgradeDataSO UpgradeData { get { return upgradeData; } }

    private PlayerData playerData;

    private void Awake()
    {
        Instance = this;

        playerData = new PlayerData();
    }

    private void Start()
    {
        for (int i = 0; i < upgradeData.Upgrades.Count; i++)
        {
            upgradeIndexes.Add(upgradeData.Upgrades[i], i);
        }

    }

    private void Update()
    {
        
    }

    public void AddPointsForClick()
    {
        playerData.points += 1;
    }

    public void AddUpgrade(UpgradeSO upgradeData, int amount)
    {
        int upgradeIndex = 0;

        if (!upgradeIndexes.TryGetValue(upgradeData, out upgradeIndex))
            return;

        if (!playerData.upgrades.ContainsKey(upgradeIndex))
            playerData.upgrades.Add(upgradeIndex, 0);

        playerData.upgrades[upgradeIndex] = playerData.upgrades[upgradeIndex] + amount;
    }

    public int GetAmountOfUpgrade(UpgradeSO upgradeData)
    {
        int upgradeIndex = 0;

        if (!upgradeIndexes.TryGetValue(upgradeData, out upgradeIndex))
            return 0;

        return playerData.upgrades[upgradeIndex];
    }
}
