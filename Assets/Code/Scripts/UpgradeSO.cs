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

    [Header("Points")]
    [SerializeField] private BigDouble basePoints = 1;
    [SerializeField] private BigDouble clickBonusPoints = 1;

    public string UpgradeName { get { return upgradeName; } }
    public Sprite Texture { get { return sprite; } }
    public BigDouble BasePrice { get { return basePrice; } }
    public float PriceModifier { get { return priceModifier; } }
    public BigDouble BasePoints { get { return basePoints; } }
    public BigDouble ClickBonusPoints { get { return clickBonusPoints; } }
}
