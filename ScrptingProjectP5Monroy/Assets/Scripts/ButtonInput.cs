using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Android;

public class ButtonInput : MonoBehaviour
{
    public Sprite standard;
    public Sprite dowwngfx;
    public Sprite upgfx;
    public Sprite heldgfx;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        bool down = Input.GetButton("Jump");
        bool held = Input.GetButton("Jump");
        bool up = Input.GetButtonUp("Jumpo");

        if (down)
        {

        }
        else if (held)
        {

        }
        else if (up)
        {

        }
        else
        {

        }

    }
}
