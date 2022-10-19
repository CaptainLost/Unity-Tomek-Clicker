using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public abstract class TooltipTrigger : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    private void Update()
    {
        if (EventSystem.current.IsPointerOverGameObject())
        {
            OnPointerStay();
        }
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        TooltipManager.Instance.ShowTooltip();
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        TooltipManager.Instance.HideTooltip();
    }

    protected abstract void OnPointerStay();
}
