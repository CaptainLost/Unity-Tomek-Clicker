using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TabSystemUI : MonoBehaviour
{
    [SerializeField] protected List<Transform> pages = new List<Transform>();

    private int currentTab = 0;

    private void Start()
    {
        OpenTab(currentTab);
    }

    public void CloseAllTabs()
    {
        foreach (Transform page in pages)
        {
            page.gameObject.SetActive(false);
        }
    }

    public void OpenTab(int tabIndex)
    {
        CloseAllTabs();

        if (tabIndex >= pages.Count)
        {
            return;
        }

        pages[tabIndex].gameObject.SetActive(true);
    }

    public void OpenNextTab()
    {
        if (pages.Count == 0)
            return;

        currentTab++;

        if (currentTab >= pages.Count)
        {
            currentTab = 0;
        }

        OpenTab(currentTab);
    }

    public void OpenPreviousTab()
    {
        if (pages.Count == 0)
            return;

        currentTab--;

        if (currentTab < 0)
        {
            currentTab = pages.Count - 1;
        }

        OpenTab(currentTab);
    }
}
