using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UIElements;

public class TooltipInfoTrigger : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    [SerializeField] private string header;
    [SerializeField] private string contnet;

    public void OnPointerEnter(PointerEventData eventData)
    {
        TooltipController.Instance.SetText(contnet, header);
        TooltipController.Instance.Show();
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        TooltipController.Instance.Hide();
    }
}
