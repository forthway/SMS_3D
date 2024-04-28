using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public float rotationSpeed = 20f;

    void Start()
    {
        
    }

    void Update()
    {
        transform.Rotate(0f, 0f, rotationSpeed);
    }
}
