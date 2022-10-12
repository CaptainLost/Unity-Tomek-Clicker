using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New upgrade data", menuName = "CptLost/New Upgrade Data")]
public class UpgradeDataSO : ScriptableObject
{
    [SerializeField] private List<UpgradeSO> upgrades;

    public List<UpgradeSO> Upgrades { get { return upgrades; } }
}
