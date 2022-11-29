using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

[Serializable]
public class PrinterStorageData
{
    public PrinterStorageData(PrinterSO printerType)
    {
        PrinterType = printerType;

        CurrentInk = printerType.InkPerLevel;
    }

    [field: SerializeField] public PrinterSO PrinterType { get; private set; }

    [field: SerializeField] public int SpeedLevel { get; set; } = 1;
    [field: SerializeField] public int InkLevel { get; set; } = 1;
    [field: SerializeField] public int CoolingLevel { get; set; } = 1;

    [SerializeField] public float PrintProgress = 0f;
    [SerializeField] public float CurrentInk = 0f;
    [SerializeField] public float CurrentTemperature = 20f;
    [SerializeField] public bool IsOverheated = false;
}

[CreateAssetMenu(fileName = "New Printer Data", menuName = "CptLost/Data/Printer Data")]
public class PrinterDataSO : ScriptableObject
{
    [field: SerializeField] public int PrinterSlots { get; private set; }
    [field: SerializeField] public List<PrinterStorageData> SlotData { get; private set; }
}
