using UnityEngine;
using TMPro;
using BreakInfinity;

public class ClickPopup : MonoBehaviour
{
    [SerializeField] private float fadeSpeed = 0.2f;
    [SerializeField] private float moveForce = 25f;
    [SerializeField] private TextMeshProUGUI textObject;

    private CanvasGroup canvasGroup;
    private Rigidbody2D rigid2D;

    private float alpha = 1f;

    private void Awake()
    {
        canvasGroup = GetComponent<CanvasGroup>();
        rigid2D = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        float xMove = Random.Range(0f, 1f);
        float yMove = 1f - xMove;

        xMove = Random.Range(0f, 1f) > 0.5f ? xMove * -1f : xMove;
        yMove = Random.Range(0f, 1f) > 0.5f ? yMove * -1f : yMove;

        rigid2D.AddForce(new UnityEngine.Vector2(xMove, yMove) * moveForce, ForceMode2D.Impulse);
    }

    private void Update()
    {
        alpha -= fadeSpeed * Time.deltaTime;
        canvasGroup.alpha = alpha;

        if (alpha <= 0f)
        {
            Destroy(gameObject);
        }
    }

    public void Init(BigDouble clickedAmount)
    {
        textObject.text = PointsHelper.FormatPoints(clickedAmount);
    }
}
