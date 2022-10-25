using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class PointPerSecondText : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI textObject;
    [SerializeField] private RectTransform horizontalLayoutGroup;

    private void Start()
    {
        UpdateDisplay();
    }

    public void UpdateDisplay()
    {
        textObject.text = PointsHelper.FormatPoints(UpgradeManager.Instance.CalulatePointsPerSeconds()) + " na sekunde";

        LayoutRebuilder.ForceRebuildLayoutImmediate(horizontalLayoutGroup);
    }
}
