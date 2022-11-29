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

        PrinterStorageData data = new PrinterStorageData(printerType);

        playerData.PrinterData.SlotData.Add(data);

        VisualManager.Instance.UpdatePrinters();

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

    public static bool BuyPrinterSpeedUpgrade(PrinterStorageData data)
    {
        if (data.SpeedLevel >= data.PrinterType.MaxLevelSpeed)
            return false;

        data.SpeedLevel++;

        VisualManager.Instance.UpdatePrinters();

        return true;
    }

    public static bool AddPrinterInkUpgrade(PrinterStorageData data)
    {
        if (data.InkLevel >= data.PrinterType.MaxLevelInk)
            return false;

        data.InkLevel++;

        VisualManager.Instance.UpdatePrinters();

        return true;
    }

    public static bool AddPrinterCoolingUpgrade(PrinterStorageData data)
    {
        if (data.CoolingLevel >= data.PrinterType.MaxLevelCooling)
            return false;

        data.CoolingLevel++;

        VisualManager.Instance.UpdatePrinters();

        return true;
    }

    public static bool PrinterHasMaxInk(PrinterStorageData data)
    {
        return (data.CurrentInk == data.PrinterType.InkPerLevel * data.InkLevel);
    }

    public static bool RefillPrinterInk(PrinterStorageData data)
    {
        data.CurrentInk = data.PrinterType.InkPerLevel * data.InkLevel;

        VisualManager.Instance.UpdatePrinters();

        return true;
    }
}
