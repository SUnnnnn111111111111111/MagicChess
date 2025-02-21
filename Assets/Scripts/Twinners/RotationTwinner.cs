using System;
using UnityEngine;
using DG.Tweening;
using UltEvents;

public class RotationTwinner : MonoBehaviour
{
    [SerializeField] private Transform targetTransform;
    [SerializeField] private AnimationCurve curve;
    [SerializeField] private float durationOfRotate = 1f;
    [SerializeField] private UltEvent OnEndOfTheRotate;



    public void LaunchTweener(Vector3 finalRotation)
    {
        targetTransform.DOKill(true);
        targetTransform.DORotate(finalRotation, durationOfRotate)
            .SetEase(curve)
            .OnComplete(CompleteTheTweener);
    }

    public void CompleteTheTweener()
    {
        OnEndOfTheRotate.Invoke();
    }
}
