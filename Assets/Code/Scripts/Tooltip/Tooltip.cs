using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Tooltip : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI contentText;

    private RectTransform rectTransform;

    private void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
    }

    public void SetText(string text)
    {
        contentText.text = text;
    }

    public void SetPosition(Vector3 position)
    {
        rectTransform.position = position;
    }

    public void SetPivot(Vector2 pivot)
    {
        rectTransform.pivot = pivot;
    }
}
