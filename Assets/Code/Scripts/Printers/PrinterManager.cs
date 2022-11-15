using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrinterManager : MonoBehaviour
{
    [SerializeField] private PlayerDataSO playerData;

    public static PrinterManager Instance;

    private void Awake()
    {
        Instance = this;
    }

    public bool AddPrinter(PrinterSO printerType)
    {
        if (playerData.PrinterData.SlotData.Count >= playerData.PrinterData.PrinterSlots)
            return false;

        playerData.PrinterData.SlotData.Add(new PrinterStorageData(printerType));

        return true;
    }

    public bool BuyPrinter(PrinterSO printerType)
    {
        if (AddPrinter(printerType))
        {


            return true;
        }

        return false;
    }
}
