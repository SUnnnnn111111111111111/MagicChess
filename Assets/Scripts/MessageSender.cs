using UnityEngine;
using UltEvents;

public class MessageSender : MonoBehaviour
{
    public void SendMessage(GameObject messageRecipient, string methodName, string inputParameter)
    {
        messageRecipient.SendMessage(methodName, inputParameter);
    }
}
