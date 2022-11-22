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

        VisualManager.Instance.UpdatePrinterUpgrades();

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

    public bool BuyPrinterSpeedUpgrade(PrinterStorageData data)
    {
        if (data.SpeedLevel >= data.PrinterType.MaxLevelSpeed)
            return false;

        data.SpeedLevel++;

        VisualManager.Instance.UpdatePrinterUpgrades();

        return true;
    }
}
