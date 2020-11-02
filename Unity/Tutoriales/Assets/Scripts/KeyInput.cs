using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeyInput : MonoBehaviour
{

    public Image graphic;
    public Sprite standard;
    public Sprite downgfx;
    public Sprite upgfx;
    public Sprite heldgfx;
    public Text guiText;

    void Start()
    {
        graphic.sprite = standard;
    }

    void Update()
    {
        bool down = Input.GetKeyDown(KeyCode.Space);
        bool held = Input.GetKey(KeyCode.Space);
        bool up = Input.GetKeyUp(KeyCode.Space);

        if(down)
        {
            graphic.sprite = downgfx;
        }

        else if (held)
        {
            graphic.sprite = heldgfx;
        }

        else if (up)
        {
            graphic.sprite = upgfx;
        }

        else
        {
            graphic.sprite = standard;
        }

    }
}
