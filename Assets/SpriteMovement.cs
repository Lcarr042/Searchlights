
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SpriteMovement : MonoBehaviour
{
    public float speed;
    //public float maxSpeed;
    private Rigidbody2D rb2d;
    

    // Start is called before the first frame update
    void Start()
    {
        
        rb2d = GetComponent<Rigidbody2D>();
        //position = gameObject.transform.position;
        speed = 10.0f;
        //maxSpeed = 50.0f;d
    }

    // Update is called once per frame
    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector2 movement = new Vector2(moveHorizontal, moveVertical);
        rb2d.velocity = movement*speed;

      
    }

}

    