using System;
using UnityEngine;
using DG.Tweening;

public class ImageClickHandler : MonoBehaviour
{
    private Vector3 _oriScale;
    private Vector3 _goToScale;
    [SerializeField] private float _scale = 2;
    private void Start()
    {
        _oriScale = transform.localScale;
        _goToScale = _oriScale * _scale;
        Debug.Log("I work");
        TweenLoop();
    }

    private void TweenLoop()
    {
        this.transform.DOScale(_goToScale, 2f)
            .SetEase(Ease.InOutSine)
            .SetLoops(-1, LoopType.Yoyo);
    }

    public void OnMouseDown()
    {
        Debug.Log("down");
    }
    private void OnMouseUp()
    {
        Debug.Log("up");
    }
}
