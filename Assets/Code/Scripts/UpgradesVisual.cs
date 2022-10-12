using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradesVisual : MonoBehaviour
{
    [SerializeField] private GameObject upgradePrefab;

    private void Start()
    {
        CreateUpgrades();
    }

    private void Update()
    {
        
    }

    public void CreateUpgrades()
    {
        for (int i = 0; i < DataManager.Instance.UpgradeData.Upgrades.Count; i++)
        {
            UpgradeSO upgradeSO = DataManager.Instance.UpgradeData.Upgrades[i];

            GameObject obj = Instantiate(upgradePrefab, transform);
            Upgrade upgrade = obj.GetComponent<Upgrade>();

            upgrade.UpdateData(upgradeSO);
        }
    }
}
