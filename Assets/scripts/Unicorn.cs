using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unicorn : MonoBehaviour
{

    public float speed = 1f;
    //public GameObject gameEngine;

    private SpriteRenderer spriteRenderer;

    // Use this for initialization
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update called as quickly machine allows
    void Update()
    {
        //code here for something non-physics-based
    }

    // Physics Update called at fixed rate
    void FixedUpdate()
    {
        var unicorn = gameObject.GetComponent<Rigidbody2D>();
        //transform.Translate(0.2f, 0f, 0f);

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            //transform.position = new Vector3(transform.position.x + speed, transform.position.y);
            unicorn.AddForce(Vector3.up * 300);
            //unicorn.AddForce(Vector3.right * 300);
        }
        /*
        if (Input.GetKeyDown(KeyCode.RightArrow)){
            //transform.position = new Vector3(transform.position.x + speed, transform.position.y);
            unicorn.AddForce(Vector3.up * 50);
            unicorn.AddForce(Vector3.right * 300);
            //gameEngine.GetComponent<gameEngine>().counter += 1;
            //Debug.Log(gameEngine.GetComponent<gameEngine>().counter);

        }
        
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            //transform.position = new Vector3(transform.position.x + speed, transform.position.y);
            //unicorn.AddForce(Vector3.up * 250);
            unicorn.AddForce(Vector3.left * 300);

        }
        */

        if (Mathf.Abs(Input.GetAxis("Horizontal")) > 0)
        {
            if (Mathf.Abs(unicorn.velocity.x) < 10)
            {
                Vector3 directionVector;

                if (Input.GetAxis("Horizontal") > 0)
                {
                    directionVector = Vector3.right;
                    spriteRenderer.flipX = false;
                }
                else
                {
                    directionVector = Vector3.left;
                    spriteRenderer.flipX = true;
                }

                unicorn.AddForce(directionVector * speed);
            }
        }

    }
}
