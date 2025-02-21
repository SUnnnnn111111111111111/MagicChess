using System;
using UnityEngine;
using DG.Tweening;
using UltEvents;

public class ShakeTwinner : MonoBehaviour
{
    [SerializeField] private Transform targetTransform; 
    [SerializeField] private float shakeDuration = 0.5f; 
    [SerializeField] private float shakeStrength = 0.5f; 
    [SerializeField] private int shakeVibrato = 10; 
    [SerializeField] private float shakeRandomness = 90f; 
    [SerializeField] private UltEvent OnEndOfTheShake; 

    public void LaunchTheShake()
    {
        targetTransform.DOKill(true);

        targetTransform.DOShakePosition(shakeDuration, shakeStrength, shakeVibrato, shakeRandomness)
            .OnComplete(CompleteTheShake);
    }

    public void LaunchTheShakeAndChangeThePosition(Vector3 localOffset)
    {
        targetTransform.DOKill(true);

        // Тряска в мировых координатах
        targetTransform.DOShakePosition(shakeDuration, shakeStrength, shakeVibrato, shakeRandomness)
            .OnComplete(() =>
        {
            // Перемещение в локальных координатах
            Vector3 newLocalPosition = targetTransform.localPosition + localOffset;
            targetTransform.DOLocalMove(newLocalPosition, shakeDuration)
                .OnComplete(CompleteTheShake);
        });
    }



    private void CompleteTheShake()
    {
        OnEndOfTheShake.Invoke();
    }
}