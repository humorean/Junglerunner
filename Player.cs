using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;
    public float jump;
    private Rigidbody2D rigidBody;

    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>(); //GetComponent is refer to the Player Class
    }

    // Update is called once per frame
    void Update()
    {
        rigidBody.velocity = new Vector2(rigidBody.velocity.x+speed, rigidBody.velocity.y);
        if(Input.GetKey("d") && rigidBody.velocity.x<3) {
            Debug.Log(rigidBody.velocity.x);

            rigidBody.velocity = new Vector2(rigidBody.velocity.x+1, rigidBody.velocity.y);
        }
        if(Input.GetKey("a") && rigidBody.velocity.x>-3) {
            rigidBody.velocity = new Vector2(rigidBody.velocity.x-1, rigidBody.velocity.y);
        }
        
        if(Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space)){
            rigidBody.velocity = new Vector2(rigidBody.velocity.x, jump);
        }
    }
}
