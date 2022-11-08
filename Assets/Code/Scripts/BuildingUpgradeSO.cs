using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BreakInfinity;

[CreateAssetMenu(fileName = "New building upgrade", menuName = "CptLost/Upgrades/Building Upgrade")]
public class BuildingUpgradeSO : UpgradeSO
{
    [Header("Price")]
    [SerializeField] private BigDouble basePrice;
    [SerializeField] private float priceModifier = 1.15f;
    [SerializeField] private BigDouble minimumAmountOfPointsToUnlock = 0;

    public BigDouble BasePrice { get { return basePrice; } }
    public float PriceModifier { get { return priceModifier; } }

    public override BigDouble CalculatePrice(int level)
    {
        return basePrice * Mathf.Pow(priceModifier, level);
    }

    public override bool IsLocked()
    {
        return DataManager.Instance.HighestAmountOfPoints < minimumAmountOfPointsToUnlock;
    }
}
