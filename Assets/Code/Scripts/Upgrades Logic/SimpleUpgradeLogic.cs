using UnityEngine;
using BreakInfinity;

public class SimpleUpgradeLogic : UpgradeLogic
{
    [SerializeField] protected UpgradeSO upgrade;
    [SerializeField] private BigDouble baseClickPoints = 0.1f;

    protected override void Tick()
    {
        BigDouble points = CalculateTickPoints();

        DataManager.Instance.AddPoints(points);
    }

    public override BigDouble CalulateClickPoints()
    {
        return 0;
    }

    public override BigDouble CalculateTickPoints()
    {
        return baseClickPoints * DataManager.Instance.GetAmountOfUpgrade(upgrade);
    }
}
