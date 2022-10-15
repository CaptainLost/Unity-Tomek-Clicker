using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class VisualManager : MonoBehaviour
{
    public static VisualManager Instance;

    public UnityEvent pointsUpdate = new UnityEvent();
    public UnityEvent upgradesUpdate = new UnityEvent();

    private void Awake()
    {
        Instance = this;
    }

    public void UpdatePoints()
    {
        pointsUpdate?.Invoke();
    }

    public void UpdateUpgrades()
    {
        upgradesUpdate?.Invoke();
    }

    public void FullUpdate()
    {
        UpdatePoints();
        UpdateUpgrades();
    }
}
