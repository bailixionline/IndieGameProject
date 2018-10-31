using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public VirturalJoystick vj;
    Rigidbody2D rb2d;
    public float movementSpeed;

    // Use this for initialization
    void Start () {
        rb2d = GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update () {      
        
        Vector2 movement = Vector2.zero;
        movement.x = vj.Horizontal() * movementSpeed;
        movement.y = vj.Vertical() * movementSpeed;

        rb2d.position += movement * Time.deltaTime;
    }
}
