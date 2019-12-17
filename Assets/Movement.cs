using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    Rigidbody2D rb;
    public float gs;
    bool spacePressed = false;
    // Start is called before the first frame update
    void Start()
    {
        
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            spacePressed = !spacePressed;
            
            
            print("neg");
            
        }

        if (spacePressed)
        {
            rb.gravityScale = gs;
        }
        else
        {
            rb.gravityScale = -gs;
        }

        /*
        if (Input.GetKeyDown(KeyCode.Space) && spacePressed == true)
        {
            spacePressed = false;
            rb.gravityScale = 1;
            
            print("Pos");
        }*/


    }
}
