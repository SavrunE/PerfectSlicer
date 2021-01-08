using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using BzKovSoft.ObjectSlicer;
using BzKovSoft.ObjectSlicerSamples;

public class Slicer : MonoBehaviour
{
    [SerializeField] private GameObject blade;
    [SerializeField] private float duration;
    [SerializeField] private float offsetY;

    private BzKnife knife;

    private void Start()
    {
        knife = blade.GetComponentInChildren<BzKnife>();
    }
    private void Update()
    {
        if (Input.GetMouseButton(0))
        {
            knife.BeginNewSlice();

            blade.transform.DOMoveY(blade.transform.position.y - offsetY, duration).SetLoops(2, LoopType.Yoyo);
        }
    }
}
