using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SingleTabUI : MonoBehaviour
{
    [SerializeField] private UnityEvent onOpen;
    [SerializeField] private UnityEvent onClose;

    private bool isOpen = false;

    private void Start()
    {
        
    }

    public void Open()
    {
        isOpen = true;

        onOpen?.Invoke();
    }

    public void Close()
    {
        isOpen = false;

        onClose?.Invoke();
    }

    public void Switch()
    {
        if (isOpen)
            Close();
        else
            Open();
    }
}
