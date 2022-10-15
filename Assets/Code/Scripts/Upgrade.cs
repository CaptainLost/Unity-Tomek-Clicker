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
    [SerializeField] private TextMeshProUGUI priceText;

    private UpgradeSO upgradeData;

    public UpgradeSO UpgradeData { get { return upgradeData; } }

    public void UpdateVisual(UpgradeSO upgradeSO)
    {
        upgradeData = upgradeSO;

        UpdateVisual();
    }

    public void UpdateVisual()
    {
        if (upgradeData == null)
            return;

        image.sprite = upgradeData.Texture;
        titleText.text = upgradeData.UpgradeName;
        amountText.text = 'x' + DataManager.Instance.GetAmountOfUpgrade(upgradeData).ToString();
        priceText.text = PointsHelper.FormatPoints(UpgradeHelper.CalculatePrice(upgradeData));
    }

    public void BuyUpgrade()
    {
        DataManager.Instance.BuyUpgrade(upgradeData);
    }
}
