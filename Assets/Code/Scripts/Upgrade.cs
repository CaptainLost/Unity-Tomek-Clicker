using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Upgrade : MonoBehaviour
{
    [SerializeField] private Image image;
    [SerializeField] private TextMeshProUGUI titleText;
    [SerializeField] private TextMeshProUGUI amountText;

    private UpgradeSO upgradeData;

    public UpgradeSO UpgradeData { get { return upgradeData; } }

    public void UpdateData(UpgradeSO upgradeSO)
    {
        upgradeData = upgradeSO;

        UpdateData();
    }

    public void UpdateData()
    {
        image.sprite = upgradeData.Texture;
        titleText.text = upgradeData.UpgradeName;
        amountText.text = 'x' + DataManager.Instance.GetAmountOfUpgrade(upgradeData).ToString();
    }

    public void AddUpgrade()
    {
        DataManager.Instance.AddUpgrade(UpgradeData, 1);
    }
}
