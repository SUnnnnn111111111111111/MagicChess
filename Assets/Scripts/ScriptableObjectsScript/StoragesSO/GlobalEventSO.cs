using System.Collections.Generic;
using UnityEngine;
using System;
using UltEvents;


[CreateAssetMenu(menuName = "Create GlobalEventSO", fileName = "GlobalEventSO", order = 0)]
public class GlobalEventSO : ScriptableObject
{
    private List<SubscriberOfGlobalEvent> subscribers = new List<SubscriberOfGlobalEvent>();

    
    public void Happen()
    {
        foreach(var subscriber in subscribers)
        {
            subscriber.React();
        }
    }
    
    public void HappenIfTrue(bool value)
    {
        if (value) Happen();
    }

    public void Subscribe(SubscriberOfGlobalEvent subscriber)
    {
        subscribers.Add(subscriber);
    }

    public void UnSubscribe(SubscriberOfGlobalEvent subscriber)
    {
        subscribers.Remove(subscriber);
    }
}
