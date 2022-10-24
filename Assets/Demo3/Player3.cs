using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class Player3 : MonoBehaviour
{
    
    void Start()
    {              //(position,duration)
        /* transform.DOMoveX(6f, 2f)
             .SetRelative(true)
             .SetEase(Ease.Linear)
             .SetSpeedBased(false)//because ours is time-based
             .SetLoops(-1, LoopType.Yoyo);//-1 is endless loop */

        transform.DORotate(Vector3.up * 360, 2f, RotateMode.FastBeyond360).onComplete = delegate
        {
            Debug.Log("Rotation Completed!!!");

        };
    }

}
