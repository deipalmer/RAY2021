using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Material_selection : MonoBehaviour
{

    public Material nuevoMaterial;
    public Renderer renderer;
    public Renderer esfera;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeMaterial()
    {
        esfera.material = nuevoMaterial;
    }
}
