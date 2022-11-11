using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BreakInfinity;

[CreateAssetMenu(fileName = "New upgrade", menuName = "CptLost/New Upgrade")]
public class UpgradeSO : ScriptableObject
{
    [SerializeField] private string upgradeName = "???";
    [SerializeField] private Sprite sprite;

    [Header("Price")]
    [SerializeField] private BigDouble basePrice;
    [SerializeField] private float priceModifier = 1.15f;

    public string UpgradeName { get { return upgradeName; } }
    public Sprite Texture { get { return sprite; } }
<<<<<<< Updated upstream
    public BigDouble BasePrice { get { return basePrice; } }
    public float PriceModifier { get { return priceModifier; } }
=======
    public int MaxAmount { get { return maxAmount; } }

    public abstract BigDouble CalculatePrice(int level);
    public virtual UpgradeStorageData CreateStorageObject()
    {
        return new UpgradeStorageData(this, 0);
    }
    public abstract bool IsLocked();
>>>>>>> Stashed changes
}
