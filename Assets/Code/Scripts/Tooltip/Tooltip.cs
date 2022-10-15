using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Tooltip : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI headerText;
    [SerializeField] private TextMeshProUGUI contentText;
    [SerializeField] private RectTransform rectTransform;
    [SerializeField] private int textWrapLimit;

    [SerializeField] private Vector2 offset;

    private void Update()
    {
        SetPosition();
    }

    private void SetPosition()
    {
        Vector2 mousePosition = Input.mousePosition;

        transform.position = mousePosition + offset;
    }

    public void SetText(string content, string header = "")
    {
        headerText.gameObject.SetActive(!string.IsNullOrEmpty(header));
        headerText.text = header;

        contentText.text = content;

        LayoutRebuilder.ForceRebuildLayoutImmediate(rectTransform);

        SetPosition();
    }
}
