using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrinterBuyPreviewUI : MonoBehaviour
{
    [SerializeField] private UpgradeDataSO upgradeData;
    [SerializeField] private GameObject nextWindow;

    [SerializeField] private PrinterSO currentPrinter;

    private void Start()
    {
        
    }

    private void Update()
    {
        
    }

    public void BuySelectedUpgrade()
    {
        if (PrinterManager.Instance.BuyPrinter(currentPrinter))
        {
            gameObject.SetActive(false);
            nextWindow.SetActive(true);
        }
    }
}
