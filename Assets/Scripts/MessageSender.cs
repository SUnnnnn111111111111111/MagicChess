using UnityEngine;
using UltEvents;

public static class MessageSender
{
    public static void SendMessage(GameObject messageRecipient, string methodName, string inputParameter)
    {
        messageRecipient.SendMessage(methodName, inputParameter);
    }
}
