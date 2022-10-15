using BreakInfinity;

public class SimpleLogic : UpgradeLogic
{
    protected override void Tick()
    {
        BigDouble points = UpgradeHelper.CalculateReceivedPointsFromUpgrade(upgrade);

        DataManager.Instance.AddPoints(points);
    }
}
