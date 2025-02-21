using System;
using UnityEngine;
using DG.Tweening;
using UltEvents;

public class MoveTwinner : MonoBehaviour
{
    [SerializeField] private Transform targetTransform;
    [SerializeField] private AnimationCurve curve;
    [SerializeField] private float durationOfMove = 1f;
    [SerializeField] private UltEvent OnEndOfTheMove;

    public void LaunchTweener(Vector3 finalPosition)
    {
        targetTransform.DOKill(true);
        targetTransform.DOLocalMove(finalPosition, durationOfMove)
            .SetEase(curve)
            .OnComplete(CompleteTheTweener); 
    }


    private void CompleteTheTweener()
    {
        OnEndOfTheMove.Invoke();
    }
}