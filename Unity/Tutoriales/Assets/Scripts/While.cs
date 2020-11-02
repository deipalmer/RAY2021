using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class While : MonoBehaviour
{

    int cupsInTheSink = 4;

    void Start()
    {
        while(cupsInTheSink>0)
        {
            Debug.Log("I've washed a cup!");
            cupsInTheSink--;
        }
    }
}
