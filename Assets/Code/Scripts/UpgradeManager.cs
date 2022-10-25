using BreakInfinity;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeManager : MonoBehaviour
{
    public static UpgradeManager Instance;

    [SerializeField] private List<UpgradeLogic> upgradeLogics;

    private void Awake()
    {
        Instance = this;
    }

    public BigDouble GetClickPointsFromUpgrades()
    {
        BigDouble points = 0;

        foreach (UpgradeLogic upgradeLogic in upgradeLogics)
        {
            points += upgradeLogic.CalulateClickPoints();
        }

        return points;
    }

    public BigDouble CalulatePointsPerSeconds()
    {
        BigDouble points = 0;

        foreach (UpgradeLogic upgradeLogic in upgradeLogics)
        {
            points += (1f / upgradeLogic.TickTime) * upgradeLogic.CalculateTickPoints();
        }

        return points;
    }
}
