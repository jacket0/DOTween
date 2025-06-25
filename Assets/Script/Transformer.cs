using DG.Tweening;
using UnityEngine;
using UnityEngine.UIElements;

public class Transformer : Activity
{
    [SerializeField] protected Vector3 _newPosition;
    [SerializeField] protected Vector3 _newRotation;
    [SerializeField] private float _newScale = 2f;

    private void Start()
    {
        Sequence sequence = DOTween.Sequence();
        sequence.Append(transform.DOMove(_newPosition, _duration).SetLoops(_repeat, _loopType));
        sequence.Insert(0f, transform.DORotate(_newRotation, _duration).SetLoops(_repeat, _loopType));
        sequence.Insert(0f, transform.DOScale(_newScale, _duration).SetLoops(_repeat, _loopType));
        sequence.SetLoops(_repeat, _loopType);
    }
}
