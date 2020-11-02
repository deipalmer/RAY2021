using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading;
using UnityEngine;

public class Condicional : MonoBehaviour
{

    float coffeeTemperature = 85.0f;
    float hotLimitTemperature = 70.0f;
    float coldLimitTemperature = 40.0f;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            TemperatureTest();

        coffeeTemperature -= Time.deltaTime * 2f;
    }

    void TemperatureTest()
    {
        //Si el café está más caliente de lo que vas a beber...
        if(coffeeTemperature>hotLimitTemperature)
        {
            //...hace esto
            print("Coffee is too hot");
        }

        //Si no lo está, pero está más frío de lo que vas a beber...
        else if (coffeeTemperature<coldLimitTemperature)
        {
            //...hace esto
            print("Coffee is too cold");
        }
        //Si no es ninguna de las otras...
        else
        {
            //...hace esto
            print("Coffee is just right");
        }

        Debug.Log(coffeeTemperature);
    }
}
