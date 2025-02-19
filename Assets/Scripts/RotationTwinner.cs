using System;
using UnityEngine;
using DG.Tweening;

public class RotationTwinner : MonoBehaviour
{
    [SerializeField] private Transform targetTransform;
    [SerializeField] private Ease curve;
    [SerializeField] private float durationOfRotate = 1f;




    public void LaunchTweener(Vector3 finalRotation)
    {
        targetTransform.DOKill(true);
        targetTransform.DORotate(finalRotation, durationOfRotate).SetEase(curve);
    }
}
