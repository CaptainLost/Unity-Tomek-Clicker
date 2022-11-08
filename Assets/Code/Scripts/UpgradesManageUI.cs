using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradesManageUI : MonoBehaviour
{
    [SerializeField] private GameObject upgradePrefab;

    private List<UpgradeUI> upgradeObjects = new List<UpgradeUI>();

    private void Start()
    {
        UpdateUpgradesUI();
    }

    public void UpdateUpgradesUI()
    {
        for (int i = 0; i < DataManager.Instance.UpgradeData.BuildingUpgrades.Count; i++)
        {
            BuildingUpgradeSO upgradeSO = DataManager.Instance.UpgradeData.BuildingUpgrades[i];

            UpgradeUI foundObject = null;
            foreach (UpgradeUI upgradeObject in upgradeObjects)
            {
                if (upgradeObject.UpgradeData == upgradeSO)
                {
                    foundObject = upgradeObject;

                    break;
                }
            }

            if (foundObject == null)
            {
                if (upgradeSO.IsLocked()) // Do not create, but allow updates
                    break;

                GameObject obj = Instantiate(upgradePrefab, transform);
                foundObject = obj.GetComponent<UpgradeUI>();

                upgradeObjects.Add(foundObject);
            }

            foundObject.UpdateVisual(upgradeSO);
        }
    }
}
