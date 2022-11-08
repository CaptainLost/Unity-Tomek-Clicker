using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TabImageButtonUI : MonoBehaviour
{
    private TabImageSystemUI system;
    private int pageIndex = 0;

    public void Init(TabImageSystemUI system, int pageIndex)
    {
        this.system = system;
        this.pageIndex = pageIndex;
    }

    public void OpenTab()
    {
        if (!system)
            return;

        system.OpenTab(pageIndex);
    }
}
