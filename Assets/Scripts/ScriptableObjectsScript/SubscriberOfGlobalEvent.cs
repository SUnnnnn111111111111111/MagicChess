using System;
using UnityEngine;
using UltEvents;

public class SubscriberOfGlobalEvent : MonoBehaviour
{
    [SerializeField] private GlobalEvent globalEvent;
    [SerializeField] private UltEvent OnEvent;
    void OnEnable()
    {
        globalEvent.Subscribe(this);
    }

    void OnDisable()
    {
        globalEvent.UnSubscribe(this);
    }

    public void React()
    {
        OnEvent.Invoke();
    }
}
