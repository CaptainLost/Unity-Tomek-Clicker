using System.Collections;
using System.Collections.Generic;
using System.Text;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PrinterBarVisualUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI progressText;
    [SerializeField] private Slider progressSlider;

    [SerializeField] private TextMeshProUGUI inkText;
    [SerializeField] private Slider inkSlider;

    [SerializeField] private Slider temperatureSlider;

    public void UpdateBars(PrinterStorageData storageData)
    {
        progressSlider.value = storageData.PrintProgress / 100f;

        StringBuilder stringBuilder = new StringBuilder();
        stringBuilder.Append("Druk: ");
        stringBuilder.Append(storageData.PrintProgress.ToString("F0"));
        stringBuilder.Append("%");

        progressText.text = stringBuilder.ToString();

        float maxInk = storageData.PrinterType.InkPerLevel * storageData.InkLevel;
        float inkPercent = storageData.CurrentInk / maxInk;
        inkSlider.value = inkPercent;

        stringBuilder = new StringBuilder();
        stringBuilder.Append("Tusz: ");
        stringBuilder.Append(Mathf.Round(inkPercent * 100f));
        stringBuilder.Append("%");

        inkText.text = stringBuilder.ToString();
    }
}
