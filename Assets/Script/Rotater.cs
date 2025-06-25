using DG.Tweening;
using UnityEngine;

public class Rotater : Activity
{
    [SerializeField] protected Vector3 _newRotation;

    void Start()
    {
        transform.DORotate(_newRotation, _duration).SetLoops(_repeat, _loopType);
    }
}
