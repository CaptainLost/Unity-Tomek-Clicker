using System.Collections;
using System.Collections.Generic;
using BreakInfinity;
using UnityEngine;
using UnityEngine.Events;

public class ClickController : MonoBehaviour
{
    [SerializeField] private UnityEvent<BigDouble> onClick;

    public void Click()
    {
        BigDouble points = UpgradeHelper.CalculateBonusClickPoints() + 1;

        DataManager.Instance.AddPoints(points);

        onClick?.Invoke(points);
    }
}
