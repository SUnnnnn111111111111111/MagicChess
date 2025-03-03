using System;
using UnityEngine;
using UltEvents;
using UnityEngine.Serialization;

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
