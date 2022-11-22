using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrinterInitUI : MonoBehaviour
{
    [SerializeField] private PlayerDataSO playerData;
    [SerializeField] private PrinterSlotUI printerSlotPrefab;

    private List<PrinterSlotUI> printerSlots = new List<PrinterSlotUI>();

    private void Start()
    {
        UpdatePrintersUI();
    }

    private void Update()
    {
        
    }

    public void UpdatePrintersUI()
    {
        if (playerData.PrinterData.PrinterSlots > printerSlots.Count)
        {
            int slotsToAdd = playerData.PrinterData.PrinterSlots - printerSlots.Count;

            for (int i = 0; i < slotsToAdd; i++)
            {
                PrinterSlotUI slotUI = Instantiate(printerSlotPrefab, transform);

                printerSlots.Add(slotUI);
            }
        }


        for (int i = 0; i < printerSlots.Count; i++)
        {
            if (playerData.PrinterData.SlotData.Count > i)
            {
                PrinterStorageData data = playerData.PrinterData.SlotData[i];

                printerSlots[i].SetManageStage(data);

                continue;
            }

            printerSlots[i].SetSelectStage();
        }
    }
}
