using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TabImageSystemUI : TabSystemUI
{
    [SerializeField] protected List<TabImageButtonUI> buttons;

    private void Start()
    {
        for (int i = 0; i < buttons.Count; i++)
        {
            if (i >= pages.Count)
                break;

            TabImageButtonUI button = buttons[i];
            button.Init(this, i);
        }
    }
}
