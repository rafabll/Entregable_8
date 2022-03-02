using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollbarScript : MonoBehaviour
{
    public void MoveCube(float sizeMultiplier)
    {
        transform.localPosition = sizeMultiplier * Vector3.one;
    }
}
