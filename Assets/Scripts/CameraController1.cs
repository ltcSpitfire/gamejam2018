using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController1 : MonoBehaviour
{
    public GameObject player;
    //public Vector3 offset;

    //public PlayerController thePlayer;
    
    //private Vector3 lastPlayerPosition;
    //private float distanceToMove;

	void Start()
    {
        //offset = transform.position - player.transform.position;

        //thePlayer = FindObjectOfType<PlayerController>();
        //lastPlayerPosition = thePlayer.transform.position;
	}

    void Update()
    {
        transform.position = new Vector3(-4.6f, player.transform.position.y + 3.8f, -6f);
        //transform.position = player.transform.position + offset;


        //distanceToMove = thePlayer.transform.position.y - lastPlayerPosition.y;

        //transform.position = new Vector3(transform.position.x, transform.position.y + distanceToMove, transform.position.z);

        //lastPlayerPosition = thePlayer.transform.position;
    }
}
