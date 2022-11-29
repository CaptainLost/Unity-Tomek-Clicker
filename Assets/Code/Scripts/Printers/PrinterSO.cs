using BreakInfinity;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Printer", menuName = "CptLost/New Printer")]
public class PrinterSO : ScriptableObject
{
    [field: SerializeField] public string PrinterName { get; private set; }
    [field: SerializeField] public Sprite Sprite { get; private set; }
    [field: SerializeField] public UnlockConditionSO UnlockCondition { get; private set; }

    [field: Header("Max Levels")]
    [field: SerializeField] public int MaxLevelSpeed { get; private set; }
    [field: SerializeField] public int MaxLevelInk { get; private set; }
    [field: SerializeField] public int MaxLevelCooling { get; private set; }

    [field: Header("Variables")]
    [field: SerializeField] public float MinTemperature { get; private set; }
    [field: SerializeField] public float MaxTemperature { get; private set; }
    [field: SerializeField] public float ProgressPerSpeedLevel { get; private set; }
    [field: SerializeField] public float InkPerLevel { get; private set; }

    [field: Header("Tick Settings")]
    [field: SerializeField] public float InkConsumptionPerTick { get; private set; }

    [field: Header("Points")]
    [field: SerializeField] public BigDouble RewardPerPrint { get; private set; }
    [field: SerializeField] public BigDouble CostPerInkRefill { get; private set; }
}
