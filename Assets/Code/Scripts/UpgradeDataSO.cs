using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New upgrade data", menuName = "CptLost/New Upgrade Data")]
public class UpgradeDataSO : ScriptableObject
{
    [field: SerializeField] public List<BuildingUpgradeSO> BuildingUpgrades { get; private set; }
    [field: SerializeField] public List<MiniUpgradeSO> MiniUpgrades { get; private set; }
    [field: SerializeField] public List<PrinterSO> PrinterList { get; private set; }
}
