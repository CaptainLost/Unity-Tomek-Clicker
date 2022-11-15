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
    }

    [field: SerializeField] public PrinterSO PrinterType { get; private set; }

    [field: SerializeField] public int SpeedLevel { get; private set; } = 0;
    [field: SerializeField] public int InkLevel { get; private set; } = 0;
    [field: SerializeField] public int CoolingLevel { get; private set; } = 0;

    [field: SerializeField] public float CurrentTemperature { get; private set; } = 20f;
}

[CreateAssetMenu(fileName = "New Printer Data", menuName = "CptLost/Data/Printer Data")]
public class PrinterDataSO : ScriptableObject
{
    [field: SerializeField] public int PrinterSlots { get; private set; }
    [field: SerializeField] public List<PrinterStorageData> SlotData { get; private set; }
}
