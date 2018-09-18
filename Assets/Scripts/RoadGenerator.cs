using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadGenerator : MonoBehaviour
{
    public GameObject theRoad;
    public Transform generationPoint;
    public float distanceBetween;

    private float roadWidth;


	// Use this for initialization
	void Start ()
    {
        roadWidth = theRoad.GetComponent<BoxCollider2D>().size.y;
	}
	
	// Update is called once per frame
	void Update ()
    {
		if (transform.position.y < generationPoint.position.y)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y + roadWidth + distanceBetween, transform.position.z);

            Instantiate(theRoad, transform.position, Quaternion.Euler(0, 0, 90));
        }
	}
}
