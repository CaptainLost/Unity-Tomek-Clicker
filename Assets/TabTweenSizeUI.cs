using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using Unity.VisualScripting.Antlr3.Runtime;

public class TabTweenSizeUI : MonoBehaviour
{
    [SerializeField] private float tweenTime = 1f;

    [SerializeField] private Vector2 closeSize;
    [SerializeField] private Vector2 openSize;

    [SerializeField] private Ease easeType;

    private RectTransform rectTransform;

    private void Start()
    {
        rectTransform = GetComponent<RectTransform>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            OnOpen();
        }
    }

    public void OnOpen()
    {
        DOTween.To(() => rectTransform.sizeDelta, x=> rectTransform.sizeDelta = x, openSize, tweenTime)
            .SetEase(easeType);
    }

    public void OnClose()
    {
        DOTween.To(() => rectTransform.sizeDelta, x => rectTransform.sizeDelta = x, closeSize, tweenTime)
            .SetEase(easeType);
    }
}
