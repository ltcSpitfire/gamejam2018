using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float forwardSpeed;
    public float sidewardSpeed;

 

    private Rigidbody2D playerRigidbody;

	// Use this for initialization
	void Start ()
    {
        playerRigidbody = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        playerRigidbody.velocity = new Vector2(playerRigidbody.velocity.x, forwardSpeed);
    }
}
