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
    [SerializeField] private TextMeshProUGUI titleText;
    [SerializeField] private TextMeshProUGUI progressText;
    [SerializeField] private TextMeshProUGUI inkText;
    [SerializeField] private TextMeshProUGUI temperatureText;
    [SerializeField] private TextMeshProUGUI speedLevelText;
    [SerializeField] private TextMeshProUGUI inkLevelText;
    [SerializeField] private TextMeshProUGUI coolingLevelText;

    [SerializeField] private Button speedUpgradeButton;
    [SerializeField] private Button inkUpgradeButton;
    [SerializeField] private Button coolingUpgradeButton;

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
            // Progress
            float progressValue = Mathf.Clamp(storageData.currentPrintProgress / upgradeData.NeededPrintAmount, 0f, 1f);

            progressSlider.value = progressValue;

            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("Druk: ");
            stringBuilder.Append((progressValue * 100f).ToString("F2"));
            stringBuilder.Append("%");

            progressText.text = stringBuilder.ToString();

            titleText.text = upgradeData.UpgradeName;

            // Ink

            // Temperature
            stringBuilder = new StringBuilder();
            stringBuilder.Append("Temperatura: ");
            stringBuilder.Append(storageData.currentTemperature.ToString("F0"));
            stringBuilder.Append("°C");

            temperatureText.text = stringBuilder.ToString();

            // Speed Level
            stringBuilder = new StringBuilder();
            stringBuilder.Append("Szybkosc: ");
            stringBuilder.Append(storageData.currentSpeedLevel.ToString());
            stringBuilder.Append("/");
            stringBuilder.Append(upgradeData.MaxSpeedLevel);
            stringBuilder.Append(" lvl");
            speedLevelText.text = stringBuilder.ToString();

            // Ink Level
            stringBuilder = new StringBuilder();
            stringBuilder.Append("Tusz: ");
            stringBuilder.Append(storageData.currentInkLevel.ToString());
            stringBuilder.Append("/");
            stringBuilder.Append(upgradeData.MaxInkLevel);
            stringBuilder.Append(" lvl");
            inkLevelText.text = stringBuilder.ToString();

            // Cooling Level
            stringBuilder = new StringBuilder();
            stringBuilder.Append("Chlodzenie: ");
            stringBuilder.Append(storageData.currentCoolingLevel.ToString());
            stringBuilder.Append("/");
            stringBuilder.Append(upgradeData.MaxCoolingLevel);
            stringBuilder.Append(" lvl");
            coolingLevelText.text = stringBuilder.ToString();
        }
    }

    public void UpdateButtonsUI()
    {
        if (upgradeData == null)
            return;

        PrinterStorageData storageData = DataManager.Instance.GetUpgradeData(upgradeData) as PrinterStorageData;

        if (storageData == null)
            return;

        speedUpgradeButton.interactable = DataManager.Instance.HasPoints(PrinterHelper.CalulateSpeedLevelPrice(upgradeData));
        speedUpgradeButton.gameObject.SetActive(!(storageData.currentSpeedLevel >= upgradeData.MaxSpeedLevel));

        inkUpgradeButton.interactable = DataManager.Instance.HasPoints(PrinterHelper.CalulateInkLevelPrice(upgradeData));
        inkUpgradeButton.gameObject.SetActive(!(storageData.currentInkLevel >= upgradeData.MaxInkLevel));

        coolingUpgradeButton.interactable = DataManager.Instance.HasPoints(PrinterHelper.CalulateCoolingLevelPrice(upgradeData));
        coolingUpgradeButton.gameObject.SetActive(!(storageData.currentCoolingLevel >= upgradeData.MaxCoolingLevel));
    }

    public void BuyUpgrade()
    {
        DataManager.Instance.BuyUpgrade(upgradeData);
    }

    public void BuyInkUpgrade()
    {
        PrinterHelper.BuyPrinterInkLevel(upgradeData, 1);
    }

    public void BuySpeedUpgrade()
    {
        PrinterHelper.BuyPrinterSpeedLevel(upgradeData, 1);
    }

    public void BuyCoolingUpgrade()
    {
        PrinterHelper.BuyPrinterCoolingLevel(upgradeData, 1);
    }
}
