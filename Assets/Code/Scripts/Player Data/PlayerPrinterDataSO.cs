using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class PrinterStorageData2
{
    public PrinterSO printerData;


}

[CreateAssetMenu(fileName = "New Printer Data", menuName = "CptLost/Data/Printer Data")]
public class PlayerPrinterDataSO : ScriptableObject
{
    [SerializeField] private int amountOfSlots = 2;
    [SerializeField] private List<PrinterStorageData2> playerPrinterData;

    public int AmountOfSlots { get { return amountOfSlots; } }
    public List<PrinterStorageData2> PlayerPrinterData { get { return playerPrinterData; } }
}
