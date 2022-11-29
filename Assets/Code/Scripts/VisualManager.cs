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
    public UnityEvent printersUpdate = new UnityEvent();

    private void Awake()
    {
        Instance = this;
    }

    public void UpdatePoints()
    {
        pointsUpdate?.Invoke();
    }

    public void UpdateUpgrades() //TODO Change name and fix dependend events calls
    {
        upgradesUpdate?.Invoke();
    }

    public void UpdatePrinters()
    {
        printersUpdate?.Invoke();
    }

    public void FullUpdate()
    {
        UpdatePoints();
        UpdateUpgrades();
        UpdatePrinters();
    }
}
