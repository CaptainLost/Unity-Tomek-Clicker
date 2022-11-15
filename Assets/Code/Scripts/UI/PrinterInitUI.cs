using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrinterInitUI : MonoBehaviour
{
    [SerializeField] private PlayerDataSO playerData;
    [SerializeField] private PrinterSlotUI printerSlotPrefab;

    private void Start()
    {
        UpdatePrintersUI();
    }

    private void Update()
    {
        
    }

    public void UpdatePrintersUI()
    {
        foreach (PrinterStorageData data in playerData.PrinterData.SlotData)
        {
            PrinterSlotUI slotUI = Instantiate(printerSlotPrefab, transform);

            slotUI.Init(data);
        }

        int slotsToAdd = playerData.PrinterData.PrinterSlots - playerData.PrinterData.SlotData.Count;
        for (int i = 0; i < slotsToAdd; i++)
        {
            PrinterSlotUI slotUI = Instantiate(printerSlotPrefab, transform);
            slotUI.Init(null);
        }
    }
}
