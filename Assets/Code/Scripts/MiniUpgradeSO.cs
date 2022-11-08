using BreakInfinity;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class UpgradeModifier
{
    [SerializeField] private UpgradeSO targetUpgrade;

    [SerializeField] private float clickPointsMultiplier = 1f;
    [SerializeField] private float tickPointsMultiplier = 1f;
    [SerializeField] private float tickTimeMultiplier = 1f;

    public float ClickPointsMultiplier { get { return clickPointsMultiplier; } }
    public float TickPointsMultiplier { get { return tickPointsMultiplier; } }
    public float TickTimeMultiplier { get { return tickTimeMultiplier; } }
}

[CreateAssetMenu(fileName = "New mini upgrade", menuName = "CptLost/Upgrades/New Mini Upgrade")]
public class MiniUpgradeSO : UpgradeSO
{
    [SerializeField] private List<UpgradeModifier> upgradeModifiers;

    public List<UpgradeModifier> UpgradeModifiers { get { return upgradeModifiers; } }

    public override BigDouble CalculatePrice(int level)
    {
        return 0;
    }

    public override bool IsLocked()
    {
        return false;
    }
}
