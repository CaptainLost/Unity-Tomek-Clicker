using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BreakInfinity;

public class ClickPopupContoller : MonoBehaviour
{
    [SerializeField] private GameObject popupPrefab;

    public void Emit(BigDouble clickedAmount)
    {
        GameObject obj = Instantiate(popupPrefab, transform);

        ClickPopup popup = obj.GetComponent<ClickPopup>();
        popup.Init(clickedAmount);
    }
}
