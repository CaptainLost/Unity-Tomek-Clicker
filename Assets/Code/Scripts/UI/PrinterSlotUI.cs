using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrinterSlotUI : MonoBehaviour
{
    [SerializeField] private GameObject addWindow;
    [SerializeField] private GameObject selectWindow;
    [SerializeField] private PrinterManageUI manageWindow;

    private PrinterStorageData data;

    private void Start()
    {
        
    }

    public void Init(PrinterStorageData printerData)
    {
        data = printerData;

        selectWindow.SetActive(false);

        bool isAddMode = (printerData == null);

        addWindow.SetActive(isAddMode);
        manageWindow.gameObject.SetActive(!isAddMode);
    }
}
