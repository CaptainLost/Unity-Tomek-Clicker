using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tomek : MonoBehaviour
{
    [SerializeField] private float changeSpeed = 1f;
    [SerializeField] private Vector2 clickSubstract = new Vector2(0.1f, 0.1f);

    private Image image;

    private Vector2 scale = new Vector2(1f, 1f);
    private float targetScale = 1f;

    private void Start()
    {
        image = GetComponent<Image>();
    }

    private void Update()
    {
        float scaleX = Mathf.Lerp(scale.x, targetScale, changeSpeed * Time.deltaTime);
        float scaleY = Mathf.Lerp(scale.y, targetScale, changeSpeed * Time.deltaTime);

        scale = new Vector2(scaleX, scaleY);

        image.rectTransform.localScale = new Vector3(scale.x, scale.y, image.rectTransform.localScale.z);
    }

    public void OnClick()
    {
        scale -= clickSubstract;

        scale.x = Mathf.Clamp(scale.x, 0.8f, 1f);
        scale.y = Mathf.Clamp(scale.y, 0.8f, 1f);
    }
}
