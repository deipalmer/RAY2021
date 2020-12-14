using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cambiar_material : MonoBehaviour
{
    //Aqui elegiremos el material
    public Material[] skin;
    //Aqui hacemos referencia al renderizado
    public MeshRenderer mRenderPers;
    public MeshRenderer mRenderInicio;

    public void ChangeSkin()
    {
        mRenderInicio.materials = skin;
        mRenderPers.materials = skin;
    }
}
