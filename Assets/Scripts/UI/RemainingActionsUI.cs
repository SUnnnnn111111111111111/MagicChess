using TMPro;
using UltEvents;
using UnityEngine;

public class RemainingActionsUI : MonoBehaviour
{
    [SerializeField] private GlobalIntStorageSO remainingActionsSO;
    [SerializeField] private  TextMeshProUGUI  remainingActionsText;
    
    void Update()
    {
        remainingActionsText.text = $"Осталось ходов: {remainingActionsSO.Value}";
    }
}
