using BreakInfinity;

public class SimpleLogicResolver : UpgradeLogicResolver
{
    protected override void Tick()
    {
        BigDouble points = UpgradeHelper.CalculateReceivedPointsFromUpgrade(upgrade);

        DataManager.Instance.AddPoints(points);
    }
}
