using BreakInfinity;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New upgrade", menuName = "CptLost/New Upgrade")]
public class UpgradeSO : ScriptableObject
{
    [SerializeField] private string upgradeName = "???";
    [SerializeField] private Sprite sprite;

    [Header("Price")]
    [SerializeField] private double basePrice = 1d;
    [SerializeField] private float priceModifier = 0.01f;

    [Header("Points")]
    [SerializeField] private double basePoints = 1;
    [SerializeField] private double clickBonusPoints = 1;

    public string UpgradeName { get { return upgradeName; } }
    public Sprite Texture { get { return sprite; } }
    public BigDouble BasePrice { get { return basePrice; } }
    public float PriceModifier { get { return priceModifier; } }
    public BigDouble BasePoints { get { return basePoints; } }
    public BigDouble ClickBonusPoints { get { return clickBonusPoints; } }
}
