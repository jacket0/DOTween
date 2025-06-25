using DG.Tweening;
using UnityEngine;

public abstract class Activity : MonoBehaviour
{
    [SerializeField] protected int _duration;
    [SerializeField] protected LoopType _loopType;
    [SerializeField] protected int _repeat;
}
