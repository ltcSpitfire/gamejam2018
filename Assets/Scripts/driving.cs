using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class driving : MonoBehaviour {
	public GameObject player1;
	//public GameObject player12;
	public float Alcohol1;
	public float alcoholaffect12;
	public float alcoholaffect1;
	public float kääntyä1;

	public GameObject player2;
	//public GameObject player22;
	public float Alcohol2;
	public float alcoholaffect22;
	public float alcoholaffect2;
	public float kääntyä2;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update ()
    {
		ekapelaaja ();
		alcoholaffect1 = Alcohol1 * Random.Range (2, 6) / 3;
		alcoholaffect12 = Alcohol1 * Random.Range (-5, 5) / 5;

		if (Input.GetKey (KeyCode.RightArrow)) {
			kääntyä1 = (2 - alcoholaffect1) * Time.deltaTime * 2;
		}

		if (Input.GetKey (KeyCode.LeftArrow)) {
			kääntyä1 = (-2 + alcoholaffect1) * Time.deltaTime * 2;
		}
		if (Input.GetKeyDown (KeyCode.LeftArrow)) {
			//spritekaantya ();
		}
		if (Input.GetKeyDown (KeyCode.RightArrow)) {
			//spritekaantya ();
		}
		if (Input.GetKeyUp (KeyCode.RightArrow)) {

			kääntyä1 = (0 + alcoholaffect12) * Time.deltaTime * 2;
			//spritekaantya ();
		}

		if (Input.GetKeyUp (KeyCode.LeftArrow)) {

			kääntyä1 = (0 + alcoholaffect12) * Time.deltaTime * 2;
			//spritekaantya ();
		}



		alcoholaffect2 = Alcohol2 * Random.Range (2, 6) / 3;
		alcoholaffect22 = Alcohol2 * Random.Range (-5, 5) / 5;

		if (Input.GetKey (KeyCode.D)) {
			kääntyä2 = (2 - alcoholaffect2) * Time.deltaTime * 2;
		}

		if (Input.GetKey (KeyCode.A)) {
			kääntyä2 = (-2 + alcoholaffect2) * Time.deltaTime * 2;
		}
		if (Input.GetKeyDown (KeyCode.A)) {
			//spritekaantya2 ();
		}
		if (Input.GetKeyDown (KeyCode.D)) {
			//spritekaantya2 ();
		}
		if (Input.GetKeyUp (KeyCode.A)) {

			kääntyä2 = (0 + alcoholaffect22) * Time.deltaTime * 2;
			//spritekaantya2 ();
		}

		if (Input.GetKeyUp (KeyCode.D)) {

			kääntyä2 = (0 + alcoholaffect22) * Time.deltaTime * 2;
			//spritekaantya2 ();
		}
	}
	public void ekapelaaja(){
		player1.transform.Translate (kääntyä1, 0, 0);

		player2.transform.Translate (kääntyä2, 0, 0);
    }
	//public void spritekaantya(){
	//	player12.transform.rotation = Quaternion.AngleAxis(kääntyä1 / Time.deltaTime * 10, Vector3.up);
	//}
	//public void spritekaantya2(){
	//	player22.transform.rotation = Quaternion.AngleAxis(kääntyä2 / Time.deltaTime * 10, Vector3.up);
	//}
}
