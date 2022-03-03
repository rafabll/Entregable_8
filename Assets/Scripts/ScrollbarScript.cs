using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollbarScript : MonoBehaviour
{
    private Vector3 startPos = new Vector3(0, 0, 0);
    public void Start()
    {
        transform.position = startPos;
    }

    public void MoveCube(float sizeMultiplier)
    {
        transform.position = sizeMultiplier * Vector3.right;
    }
}
