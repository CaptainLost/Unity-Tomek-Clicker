using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrinterManageUI : MonoBehaviour
{
    [SerializeField] private GameObject upgradePrefab;

    private List<PrinterUpgradeUI> upgradeObjects = new List<PrinterUpgradeUI>();

    private void Start()
    {
        UpdateUpgradesUI();
    }

    public void UpdateUpgradesUI()
    {
        for (int i = 0; i < DataManager.Instance.UpgradeData.PrinterUpgrades.Count; i++)
        {
            PrinterUpgradeSO upgradeSO = DataManager.Instance.UpgradeData.PrinterUpgrades[i];

            PrinterUpgradeUI foundObject = null;
            foreach (PrinterUpgradeUI upgradeObject in upgradeObjects)
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
                foundObject = obj.GetComponent<PrinterUpgradeUI>();

                upgradeObjects.Add(foundObject);
            }

            foundObject.UpdateVisual(upgradeSO);
        }
    }

    public void UpdateButtonsUI()
    {
        foreach (PrinterUpgradeUI upgradeObject in upgradeObjects)
        {
            upgradeObject.UpdateButtonsUI();
        }
    }
}
