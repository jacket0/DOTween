using DG.Tweening;
using UnityEngine;

public class ColorChanger : Activity
{
    [SerializeField] private Color _color;
    [SerializeField] private MeshRenderer _renderer;

    private void Start()
    {
        _renderer.material.DOColor(_color, _duration).SetLoops(_repeat, _loopType);
    }
}
