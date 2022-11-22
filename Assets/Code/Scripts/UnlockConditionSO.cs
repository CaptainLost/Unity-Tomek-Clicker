using BreakInfinity;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public struct UnlockUpgrade
{
    [field: SerializeField] public UpgradeSO Upgrade { get; private set; }
    [field: SerializeField] public int Amount { get; private set; }
}

[CreateAssetMenu(fileName = "New Unlock Condition", menuName = "CptLost/Unlock Condition")]
public class UnlockConditionSO : ScriptableObject
{
    [field: SerializeField] public List<UnlockUpgrade> unlockUpgrades;
    [field: SerializeField] public BigDouble NeededPoints { get; private set; }

    public bool IsMet()
    {
        if (DataManager.Instance.Points < NeededPoints)
            return false;

        foreach (UnlockUpgrade unlock in unlockUpgrades)
        {
            if (DataManager.Instance.GetAmountOfUpgrade(unlock.Upgrade) < unlock.Amount)
            {
                return false;
            }
        }

        return true;
    }
}
