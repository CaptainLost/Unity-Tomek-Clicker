using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TooltipManager : MonoBehaviour
{
    public static TooltipManager Instance;

    [SerializeField] private Tooltip tooltip;

    private bool isActive = false;

    private void Awake()
    {
        Instance = this;
    }

    public void ShowTooltip()
    {
        isActive = true;

        tooltip.gameObject.SetActive(isActive);
    }

    public void HideTooltip()
    {
        isActive = false;

        tooltip.gameObject.SetActive(isActive);
    }

    public void SetText(string text)
    {
        tooltip.SetText(text);
    }

    public void SetPosition(Vector3 position, Vector2 pivot)
    {
        tooltip.SetPivot(pivot);
        tooltip.SetPosition(position);
    }
}
