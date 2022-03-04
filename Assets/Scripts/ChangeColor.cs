using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    public Renderer cubeRenderer;
    public GameObject cube;
    [SerializeField] private Color[] colors;
    private int colorValue;
    // Start is called before the first frame update
    void Start()
    {
        cubeRenderer = cube.GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void changeMaterial()
    {
        
        colorValue++;
        if(colorValue > 3)
        {
            colorValue = 0;
        }
        cubeRenderer.material.color = colors[colorValue];
    }
}
