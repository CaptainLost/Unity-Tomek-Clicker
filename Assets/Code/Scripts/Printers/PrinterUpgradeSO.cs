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

    [Header("Max Levels")]
    [MinAttribute(1)] [SerializeField] private int maxSpeedLevel = 10;
    [MinAttribute(1)] [SerializeField] private int maxInkLevel = 10;
    [MinAttribute(1)] [SerializeField] private int maxCoolingLevel = 20;

    [Header("Prices")]
    [SerializeField] private BigDouble baseSpeedPrice = 0f;
    [SerializeField] private float speedPriceModifier = 1.15f;
    [SerializeField] private BigDouble baseInkPrice = 0f;
    [SerializeField] private float inkPriceModifier = 1.15f;
    [SerializeField] private BigDouble baseCoolingPrice = 0f;
    [SerializeField] private float coolingPriceModifier = 1.15f;

    [Header("Temperatures")]
    [SerializeField] private float minTemperature = 20f;
    [SerializeField] private float maxTemperature = 80f;

    public float MaxInk { get { return maxInk; } }
    public float NeededPrintAmount { get { return neededPrintAmount; } }
    public float BasePrintAmount { get { return basePrintAmount; } }
    public BigDouble BaseSpeedPrice { get { return baseSpeedPrice; } }
    public float SpeedPriceModifier { get { return speedPriceModifier; } }
    public BigDouble BaseInkPrice { get { return baseInkPrice; } }
    public float InkPriceModifier { get { return inkPriceModifier; } }
    public BigDouble BaseCoolingPrice { get { return baseCoolingPrice; } }
    public float CoolingPriceModifier { get { return coolingPriceModifier; } }
    public float MaxSpeedLevel { get { return maxSpeedLevel; } }
    public float MaxInkLevel { get { return maxInkLevel; } }
    public float MaxCoolingLevel { get { return maxCoolingLevel; } }
    public float MinTemperature { get { return minTemperature; } }
    public float MaxTemperature { get { return maxTemperature; } }

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
