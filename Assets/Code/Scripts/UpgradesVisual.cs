using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradesVisual : MonoBehaviour
{
    [SerializeField] private GameObject upgradePrefab;

    private List<Upgrade> upgradeObjects = new List<Upgrade>();

    private void Start()
    {
        CreateUpgrades();
    }

    public void CreateUpgrades()
    {
        for (int i = 0; i < DataManager.Instance.UpgradeData.Upgrades.Count; i++)
        {
            UpgradeSO upgradeSO = DataManager.Instance.UpgradeData.Upgrades[i];

            GameObject obj = Instantiate(upgradePrefab, transform);
            Upgrade upgrade = obj.GetComponent<Upgrade>();

            upgrade.UpdateVisual(upgradeSO);

            upgradeObjects.Add(upgrade);
        }
    }

    public void UpdateUpgrades()
    {
        for (int i = 0; i < upgradeObjects.Count; i++)
        {
            Upgrade upgrade = upgradeObjects[i];

            upgrade.UpdateVisual();
        }
    }
}
