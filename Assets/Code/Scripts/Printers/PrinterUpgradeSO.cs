using BreakInfinity;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New printer upgrade", menuName = "CptLost/Upgrades/Printer Upgrade")]
public class PrinterUpgradeSO : UpgradeSO
{
    [SerializeField] private float maxInk = 100f;
    [SerializeField] private float neededPrintAmount = 100f;
    [SerializeField] private float basePrintAmount = 0.1f;

    public float MaxInk { get { return maxInk; } }
    public float NeededPrintAmount { get { return neededPrintAmount; } }
    public float BasePrintAmount { get { return basePrintAmount; } }

    public override BigDouble CalculatePrice(int level)
    {
        return 0;
    }

    public override bool IsLocked()
    {
        return false;
    }

    public override UpgradeStorageData CreateStorageObject()
    {
        return new PrinterStorageData(this, 0);
    }
}
