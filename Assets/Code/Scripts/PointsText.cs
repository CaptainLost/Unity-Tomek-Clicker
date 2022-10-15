using UnityEngine;
using TMPro;

public class PointsText : MonoBehaviour
{
    private TextMeshProUGUI textObject;

    private void Awake()
    {
        textObject = GetComponent<TextMeshProUGUI>();
    }

    private void Start()
    {
        UpdateDisplay();
    }

    public void UpdateDisplay()
    {
        textObject.text = "Sprawozdania: " + PointsHelper.FormatPoints(DataManager.Instance.GetPoints());
    }
}
