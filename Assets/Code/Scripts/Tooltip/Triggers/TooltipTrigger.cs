using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public abstract class TooltipTrigger : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    [SerializeField] private TooltipPosition tooltipPosition;
    [SerializeField] private Vector2 offset;

    private RectTransform rectTransform;

    private void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
    }

    private void Update()
    {
        if (EventSystem.current.IsPointerOverGameObject())
        {
            SetPosition();
            OnPointerStay();
        }
    }
    protected abstract void OnPointerStay();

    public void OnPointerEnter(PointerEventData eventData)
    {
        TooltipManager.Instance.ShowTooltip();
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        TooltipManager.Instance.HideTooltip();
    }

    public virtual void SetPosition()
    {
        Vector3 position = new Vector3();
        Vector2 pivot = new Vector2();

        switch (tooltipPosition)
        {
            case TooltipPosition.Bottom:
                pivot = new Vector2(0.5f, 1f);
                position = rectTransform.position + new Vector3(offset.x, -rectTransform.sizeDelta.y + offset.y, 0f);
                break;
        }

        TooltipManager.Instance.SetPosition(position, pivot);
    }
}
