using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    public float rotationSpeed = 1.0f;
    public Vector3 scaleSpeed;


    public bool isRotation = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isRotation==true) 
        { 
            transform.Rotate(rotationSpeed, rotationSpeed, rotationSpeed);
        }

        transform.localScale = transform.localScale + scaleSpeed * Time.deltaTime;

    }
}
