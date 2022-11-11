using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New printer", menuName = "CptLost/Upgrades/Printers/Printer")]
public class PrinterSO : ScriptableObject
{
    [field: SerializeField] public string upgradeName { get; private set; }
    [field: SerializeField] public Sprite sprite { get; private set; }

    [field: SerializeField] public UnlockConditionSO unlockCondition { get; private set; }
}
