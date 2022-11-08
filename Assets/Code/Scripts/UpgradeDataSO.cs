using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New upgrade data", menuName = "CptLost/New Upgrade Data")]
public class UpgradeDataSO : ScriptableObject
{
    [SerializeField] private List<BuildingUpgradeSO> buildingUpgrades;
    [SerializeField] private List<MiniUpgradeSO> miniUpgrades;
    [SerializeField] private List<PrinterUpgradeSO> printerUpgrades;

    public List<BuildingUpgradeSO> BuildingUpgrades { get { return buildingUpgrades; } }
    public List<MiniUpgradeSO> MiniUpgrades { get { return miniUpgrades; } }
    public List<PrinterUpgradeSO> PrinterUpgrades { get { return printerUpgrades; } }
}
