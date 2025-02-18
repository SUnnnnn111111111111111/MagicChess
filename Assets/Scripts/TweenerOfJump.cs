using System;
using UnityEngine;
using DG.Tweening;

public class TweenerOfJump : MonoBehaviour
{
    [SerializeField] private Transform targetTransform;
    [SerializeField] private Ease curve;
    [SerializeField] private float durationOfJump = 1f;
    [SerializeField] private float forceOfJump = 1f;
    [SerializeField] private int countOfJump = 2;



    public void LaunchTweener(Vector3 finalPposition)
    {
        targetTransform.DOKill(true);
        targetTransform.DOJump(finalPposition, forceOfJump, countOfJump, durationOfJump).SetEase(curve);
    }
}
