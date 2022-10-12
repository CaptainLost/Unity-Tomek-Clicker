using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PointsDisplay : MonoBehaviour
{
    private TextMeshProUGUI textObject;

    private void Start()
    {
        textObject = GetComponent<TextMeshProUGUI>();
    }

    public void UpdateDisplay()
    {
        textObject.text = "Sprawozdania: " + DataManager.Instance.PlayerData.points.ToString();
    }
}
