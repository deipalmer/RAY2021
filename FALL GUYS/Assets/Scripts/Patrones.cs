using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrones : MonoBehaviour
{

    public Texture pattern;
    public MeshRenderer mRendererInicio;
    public MeshRenderer mRendererPers;

    public void ApplyPatern()
    {
        //renderer.material.SetTexture("_MainTex", pattern);

        for(int i=0;i<3;i++)
        {
            mRendererInicio.materials[i].SetTexture("_MainTex", pattern);
            mRendererPers.materials[i].SetTexture("_MainTex", pattern);
        }
    }
}
