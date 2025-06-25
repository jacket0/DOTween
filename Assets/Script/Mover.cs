using DG.Tweening;
using UnityEngine;

public class Mover : Activity
{
    [SerializeField] protected Vector3 _newPosition;

    private void Start()
    {
        transform.DOMove(_newPosition, _duration).SetLoops(_repeat, _loopType);
    }
}
