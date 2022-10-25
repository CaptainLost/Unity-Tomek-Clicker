using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TabSystem : MonoBehaviour
{
    [SerializeField] protected List<Transform> tabs = new List<Transform>();

    private int currentTab = 0;

    private void Start()
    {
        OpenTab(currentTab);
    }

    public void CloseAllTabs()
    {
        foreach (Transform tab in tabs)
        {
            tab.gameObject.SetActive(false);
        }
    }

    public void OpenTab(int tabIndex)
    {
        CloseAllTabs();

        if (tabIndex >= tabs.Count)
        {
            return;
        }

        tabs[tabIndex].gameObject.SetActive(true);
    }

    public void OpenNextTab()
    {
        if (tabs.Count == 0)
            return;

        currentTab++;

        if (currentTab >= tabs.Count)
        {
            currentTab = 0;
        }

        OpenTab(currentTab);
    }

    public void OpenPreviousTab()
    {
        if (tabs.Count == 0)
            return;

        currentTab--;

        if (currentTab < 0)
        {
            currentTab = tabs.Count - 1;
        }

        OpenTab(currentTab);
    }
}
