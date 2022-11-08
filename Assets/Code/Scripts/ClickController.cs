using System.Collections;
using System.Collections.Generic;
using BreakInfinity;
using UnityEngine;
using UnityEngine.Events;

public class ClickController : MonoBehaviour
{
    [SerializeField] private BigDouble baseClickPoints = 1;
    [SerializeField] private UnityEvent<BigDouble> onClick;

    public void Click()
    {
        BigDouble points = UpgradeManager.Instance.GetClickPointsFromUpgrades() + baseClickPoints;

        DataManager.Instance.AddPoints(points);

        onClick?.Invoke(points);
    }
}
