using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class TextChanger : Activity
{
    [SerializeField] private Text _text;
    [SerializeField] private string _result;
    [SerializeField] private ScrambleMode _mode;

    private void Start()
    {
        Sequence sequence = DOTween.Sequence();
        sequence.Append(_text.DOText(_result, _duration));
        sequence.Append(_text.DOText(_result, _duration).SetRelative());
        sequence.Append(_text.DOText(_result, _duration, true, _mode));
        sequence.SetLoops(_repeat, _loopType);
    }
}
