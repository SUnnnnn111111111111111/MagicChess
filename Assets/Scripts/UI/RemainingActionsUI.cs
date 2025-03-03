using TMPro;
using UltEvents;
using UnityEngine;
using UnityEngine.Serialization;

public class RemainingActionsUI : MonoBehaviour
{
    [FormerlySerializedAs("remainingActionsSO")] [SerializeField] private GlobalIntStorage remainingActions;
    [SerializeField] private  TextMeshProUGUI  remainingActionsText;
    
    void Update()
    {
        remainingActionsText.text = $"Осталось ходов: {remainingActions.Value}";
    }
}
