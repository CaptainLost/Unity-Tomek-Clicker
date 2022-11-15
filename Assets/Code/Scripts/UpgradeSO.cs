using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BreakInfinity;

public abstract class UpgradeSO : ScriptableObject
{
    [SerializeField] private string upgradeName = "???";
    [SerializeField] private Sprite sprite;

    [SerializeField] private int maxAmount = 0;

    public string UpgradeName { get { return upgradeName; } }
    public Sprite Texture { get { return sprite; } }
    public int MaxAmount { get { return maxAmount; } }

    public abstract BigDouble CalculatePrice(int level);
    public virtual UpgradeStorageData CreateStorageObject()
    {
        return new UpgradeStorageData(this, 0);
    }
    public abstract bool IsLocked();
}
