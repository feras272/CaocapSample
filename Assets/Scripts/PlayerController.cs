using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public Rigidbody2D rb;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow)){
            
            transform.position = new Vector2(transform.position.x -2,rb.position.y);
            
            //transform.position = new Vector3(-2,transform.position.y,0);
        }

         if (Input.GetKeyDown(KeyCode.RightArrow)){
            //rb.velocity = new Vector2 (2,0);
            
            transform.position = new Vector2 (transform.position.x +2,rb.position.y);
            
            //transform.position = new Vector3(2,transform.position.y,0);
        }

        transform.Translate (Vector2.up * speed * Time.deltaTime);
    }

    
}
