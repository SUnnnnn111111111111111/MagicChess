using System;
using UnityEngine;
using UltEvents;
using UnityEngine.Serialization;

public class SubscriberOfGlobalEvent : MonoBehaviour
{
    [FormerlySerializedAs("globalEvent")] [SerializeField] private GlobalEventSO globalEventSo;
    [SerializeField] private UltEvent OnEvent;
    void OnEnable()
    {
        globalEventSo.Subscribe(this);
    }

    void OnDisable()
    {
        globalEventSo.UnSubscribe(this);
    }

    public void React()
    {
        OnEvent.Invoke();
    }
}
