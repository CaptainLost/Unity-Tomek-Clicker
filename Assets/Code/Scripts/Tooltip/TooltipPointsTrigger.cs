using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using BreakInfinity;
using UnityEngine.EventSystems;

public class TooltipPointsTrigger : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    private void Update()
    {
        if (EventSystem.current.IsPointerOverGameObject())
        {
            TooltipController.Instance.SetText(DataManager.Instance.GetPoints().ToString("F0"));
        }
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        TooltipController.Instance.SetText(DataManager.Instance.GetPoints().ToString("F0"));
        TooltipController.Instance.Show();
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        TooltipController.Instance.Hide();
    }
}
