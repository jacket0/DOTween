using DG.Tweening;
using UnityEngine;

public class Scaler : Activity
{
    [SerializeField] private float _newScale = 2f;

    private void Start()
    {
        transform.DOScale(_newScale, _duration).SetLoops(_repeat, _loopType);
    }
}
