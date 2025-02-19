using System.Collections.Generic;
using UnityEngine;
using System;
using UltEvents;

[CreateAssetMenu(fileName = "GlobalEvent", menuName = "ScriptableObjects/GlobalEvent", order = 1)]
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

    public void Subscribe(SubscriberOfGlobalEvent subscriber)
    {
        subscribers.Add(subscriber);
    }

    public void UnSubscribe(SubscriberOfGlobalEvent subscriber)
    {
        subscribers.Remove(subscriber);
    }
}
