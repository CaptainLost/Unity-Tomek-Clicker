using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PrinterUpgradeUI : MonoBehaviour
{
    [SerializeField] private Image image;
    [SerializeField] private Slider progressSlider;
    [SerializeField] private TextMeshProUGUI progressText;

    private PrinterUpgradeSO upgradeData;

    public PrinterUpgradeSO UpgradeData { get { return upgradeData; } }

    public void UpdateVisual(PrinterUpgradeSO upgradeSO)
    {
        upgradeData = upgradeSO;

        UpdateVisual();
    }

    public void UpdateVisual()
    {
        if (upgradeData == null)
            return;

        image.sprite = upgradeData.Texture;

        PrinterStorageData storageData = DataManager.Instance.GetUpgradeData(upgradeData) as PrinterStorageData;

        if (storageData != null)
        {
            float sliderValue = Mathf.Clamp(storageData.currentPrintProgress / upgradeData.NeededPrintAmount, 0f, 1f);

            progressSlider.value = sliderValue;

            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("Druk: ");
            stringBuilder.Append((sliderValue * 100f).ToString("F2"));
            stringBuilder.Append("%");

            progressText.text = stringBuilder.ToString();
        }
    }

    public void BuyUpgrade()
    {
        DataManager.Instance.BuyUpgrade(upgradeData);
    }
}
