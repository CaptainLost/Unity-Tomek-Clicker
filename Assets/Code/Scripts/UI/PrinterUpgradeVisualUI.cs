using System.Collections;
using System.Collections.Generic;
using System.Text;
using TMPro;
using UnityEngine;

public class PrinterUpgradeVisualUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI speedText;
    [SerializeField] private TextMeshProUGUI inkText;
    [SerializeField] private TextMeshProUGUI coolingText;

    public void UpdateUpgrade(PrinterStorageData storageData)
    {
        StringBuilder stringBuilder = new StringBuilder();

        stringBuilder.Append("Szybkosc: ");
        stringBuilder.Append(storageData.SpeedLevel);
        stringBuilder.Append("/");
        stringBuilder.Append(storageData.PrinterType.MaxLevelSpeed);
        speedText.text = stringBuilder.ToString();

        stringBuilder = new StringBuilder();
        stringBuilder.Append("Tusz: ");
        stringBuilder.Append(storageData.InkLevel);
        stringBuilder.Append("/");
        stringBuilder.Append(storageData.PrinterType.MaxLevelInk);
        inkText.text = stringBuilder.ToString();

        stringBuilder = new StringBuilder();
        stringBuilder.Append("Chlodzenie: ");
        stringBuilder.Append(storageData.CoolingLevel);
        stringBuilder.Append("/");
        stringBuilder.Append(storageData.PrinterType.MaxLevelCooling);
        coolingText.text = stringBuilder.ToString();
    }
}
