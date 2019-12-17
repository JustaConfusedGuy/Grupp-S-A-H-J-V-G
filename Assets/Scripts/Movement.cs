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
        
 

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.transform.tag == "Death")
        {
            SceneManager.LoadScene("Scene", LoadSceneMode.Single);
        }

        if (collision.gameObject.tag == "Ground")
        {
            isGrounded = true;
            print("collision");


        }


    }
    
}
        
        


    

