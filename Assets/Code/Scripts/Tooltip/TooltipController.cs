using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TooltipController : MonoBehaviour
{
    public static TooltipController Instance;

    [SerializeField] private Tooltip tooltip;

    private void Awake()
    {
        Instance = this;
    }

    public void SetText(string content, string header = "")
    {
        tooltip.SetText(content, header);
    }

    public void Show()
    {
        Instance.tooltip.gameObject.SetActive(true);
    }

    public void Hide()
    {
        Instance.tooltip.gameObject.SetActive(false);
    }
}
