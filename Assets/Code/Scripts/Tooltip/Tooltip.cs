using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Tooltip : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI contentText;

    private void Update()
    {
        
    }

    public void SetText(string text)
    {
        contentText.text = text;
    }
}
