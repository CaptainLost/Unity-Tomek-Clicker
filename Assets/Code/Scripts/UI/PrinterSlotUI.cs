using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrinterSlotUI : MonoBehaviour
{
    [SerializeField] private GameObject addWindow;
    [SerializeField] private PrinterSelectUI selectWindow;
    [SerializeField] private PrinterManageUI manageWindow;

    public PrinterStorageData StorageData { get; private set; }

    private void Start()
    {
        
    }

    public void SetManageStage(PrinterStorageData storageData)
    {
        StorageData = storageData;

        addWindow.SetActive(false);
        selectWindow.gameObject.SetActive(false);

        manageWindow.UpdateUI();
        manageWindow.gameObject.SetActive(true);
    }

    public void SetSelectStage()
    {
        addWindow.SetActive(!selectWindow.gameObject.activeSelf);
        selectWindow.gameObject.SetActive(!addWindow.activeSelf);

        manageWindow.gameObject.SetActive(false);
    }
}
