using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingHouse : MonoBehaviour
{
    [SerializeField] Vector3 pos1;
    [SerializeField] Vector3 pos2;
    void Start()
    {
        this.transform.DOLocalMove(pos2, 2f).SetLoops(-1, LoopType.Yoyo).SetEase(Ease.InOutSine);
    }

}
