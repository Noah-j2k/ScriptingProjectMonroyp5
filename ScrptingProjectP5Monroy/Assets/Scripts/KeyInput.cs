using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyInput : MonoBehaviour
{
    public Sprite standard;
    public Sprite downgfx;
    public Sprite upgfx;
    public Sprite heldgfx;
   


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bool down = Input.GetKeyDown(KeyCode.Space);
        bool held = Input.GetKey(KeyCode.Space);
        bool up = Input.GetKeyUp(KeyCode.Space);

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
