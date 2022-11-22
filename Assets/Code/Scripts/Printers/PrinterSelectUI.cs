using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrinterSelectUI : MonoBehaviour
{
    [SerializeField] private PrinterSlotUI holdingSlot;
    [SerializeField] private UpgradeDataSO upgradeData;
    [SerializeField] private PrinterSetVisualUI visualSet;

    private int currentSelectedIndex = -1;
    private PrinterSO currentPrinter;

    private void Start()
    {
        SelectNext();
    }

    public void BuySelectedUpgrade()
    {
        PrinterManager.Instance.BuyPrinter(currentPrinter);
    }

    public void SelectNext()
    {
        for (int i = currentSelectedIndex + 1; i < upgradeData.PrinterList.Count; i++)
        {
            PrinterSO printer = upgradeData.PrinterList[i];

            if (printer.UnlockCondition != null && !printer.UnlockCondition.IsMet())
                continue;

            currentSelectedIndex = i;
            currentPrinter = printer;

            visualSet.Set(printer);

            break;
        }
    }

    public void SelectPrevious()
    {
        for (int i = currentSelectedIndex - 1; i >= 0; i--)
        {
            PrinterSO printer = upgradeData.PrinterList[i];

            if (printer.UnlockCondition != null && !printer.UnlockCondition.IsMet())
                continue;

            currentSelectedIndex = i;
            currentPrinter = printer;

            visualSet.Set(printer);

            break;
        }
    }
}
