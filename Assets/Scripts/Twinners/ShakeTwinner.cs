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

            Vector3 newLocalPosition = targetTransform.localPosition + localOffset;
        targetTransform.DOLocalMove(newLocalPosition, shakeDuration)
            .OnComplete(() =>
            {
                targetTransform.DOShakePosition(shakeDuration, shakeStrength, shakeVibrato, shakeRandomness)
                    .OnComplete(CompleteTheShake);
            });
    }



    private void CompleteTheShake()
    {
        OnEndOfTheShake.Invoke();
    }
}

        