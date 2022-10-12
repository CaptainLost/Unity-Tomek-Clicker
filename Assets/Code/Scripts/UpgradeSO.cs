using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New upgrade", menuName = "CptLost/New Upgrade")]
public class UpgradeSO : ScriptableObject
{
    [SerializeField] private string upgradeName = "???";
    [SerializeField] private Sprite sprite;

    [SerializeField] private float baseCooldown = 1f;
    [SerializeField] private float baseAmount = 1f;

    public string UpgradeName { get { return upgradeName; } }
    public Sprite Texture { get { return sprite; } }
}
