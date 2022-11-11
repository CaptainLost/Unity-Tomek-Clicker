using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class UnlockUpgrade
{
    [field: SerializeField] public UpgradeSO Upgrade { get; private set; }
    [field: SerializeField] public int Amount { get; private set; }
}

[CreateAssetMenu(fileName = "New Unlock Condition", menuName = "CptLost/Unlock Condition")]
public class UnlockConditionSO : ScriptableObject
{
    [SerializeField] private List<UnlockUpgrade> unlockConditions;

    public bool IsMet()
    {
        foreach (UnlockUpgrade condition in unlockConditions)
        {
            if (DataManager.Instance.GetAmountOfUpgrade(condition.Upgrade) < condition.Amount)
            {
                return false;
            }
        }

        return true;
    }
}
