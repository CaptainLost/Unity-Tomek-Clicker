using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

public class TooltipTriggerTotalPoints : TooltipTrigger
{
    protected override void OnPointerStay()
    {
        StringBuilder stringBuilder = new StringBuilder();
        stringBuilder.Append("Sprawozdania: ");
        stringBuilder.Append(DataManager.Instance.GetPoints().ToString("F3"));

        TooltipManager.Instance.SetText(stringBuilder.ToString());
    }
}
