using System.Collections.Generic;
using UnityEngine;
using System;
using UltEvents;


[CreateAssetMenu(fileName = "GlobalEvent", menuName = "GlobalEvent/GlobalEvent")]
public class GlobalEvent : ScriptableObject
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
