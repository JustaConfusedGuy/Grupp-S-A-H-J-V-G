using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Movement : MonoBehaviour
{
    Rigidbody2D rb;
    public float gs;
    bool spacePressed = false;
    bool isGrounded = false;
    // Start is called before the first frame update
    void Start()
    {
        
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded == true)
        {
            spacePressed = !spacePressed;

            isGrounded = false;
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
    private void OnCollisionEnter2D(Collision2D collision)
    {
<<<<<<< HEAD
        if (collision.transform.tag == "Death")
        {
            SceneManager.LoadScene("Scene", LoadSceneMode.Single);
        }
    }
   
       
    

=======
        if(collision.gameObject.tag == "Ground")
        {
            isGrounded = true;
            print("collision");
        }
        
    }
>>>>>>> 9fc6b689e25159e4c93b9b4d5523a7550ccf66b6
}
