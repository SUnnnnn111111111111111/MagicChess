using System;
using UnityEngine;
using DG.Tweening;

public class MoveTwinner : MonoBehaviour
{
    [SerializeField] private Transform targetTransform;
    [SerializeField] private AnimationCurve curve;
    [SerializeField] private float durationOfMove = 1f;


    public void LaunchTweener(Vector3 finalPosition)
    {
        targetTransform.DOKill(true);
        targetTransform.DOLocalMove(finalPosition, durationOfMove);
    }
}