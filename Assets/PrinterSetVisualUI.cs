using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PrinterSetVisualUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI title;
    [SerializeField] private Image previewImage;

    public void Set(PrinterSO printerData)
    {
        if (title != null)
            title.text = printerData.PrinterName;

        if (previewImage != null)
            previewImage.sprite = printerData.Sprite;
    }
}
