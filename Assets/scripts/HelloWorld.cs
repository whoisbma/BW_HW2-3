using UnityEngine;
using System.Collections;

public class HelloWorld : MonoBehaviour {

	// this is a VARIABLE, a piece of data that remembers our "current room" / position in world
	public int currentStep = 0;
	public int fanSpeedMod = 75;

	//Vector3 origViewPos = GameObject.Find ("Main Camera").transform.position;

	// Use this for initialization
	void Start () {
		// if you see "//" that's a comment, NOT code that is run
		// all instructions have to go inside functions
		Debug.Log ( "Hello World" );

	}
	
	// Update is called once per frame
	void Update () {

				//GetComponent<TextMesh>().text = "Hola Mundo";

				// when you use an "if/else" structure, only ONE of those
				// blocks will ever run, it is an either/or scenario!
				if (currentStep == 0) {
						GetComponent<TextMesh> ().text = ". . . . . . . ";
						GetComponent<TextMesh> ().text += "\nPress any key to wake up.";

						if (Input.anyKeyDown) {
								currentStep = 1;
								fanSpeedMod = 75;
						}

				} else if (currentStep == 1) {
						GetComponent<TextMesh> ().text = ". . . . ";
						if (Input.anyKeyDown) {
								currentStep = 2;
								fanSpeedMod = 80;
						}
				} else if (currentStep == 2) {
						GetComponent<TextMesh> ().text = ". . . Press any key to wake UP.";
						if (Input.anyKeyDown) {
								currentStep = 3;
								fanSpeedMod = 85;
						}
				} else if (currentStep == 3) {
						GetComponent<TextMesh> ().text = "Wake up.";
						if (Input.anyKeyDown) {
								currentStep = 4;
								fanSpeedMod = 95;
						}
				} else if (currentStep == 4) {
						GetComponent<TextMesh> ().text = "GET UP.";
						if (Input.anyKeyDown) {
								currentStep = 5;
								fanSpeedMod = 250;
						}
				} else if (currentStep == 5) {
						GetComponent<TextMesh> ().text = "HEY";
						if (Input.anyKeyDown) {
								currentStep = 6;
								fanSpeedMod = 50;
						}
				} else if (currentStep == 6) {
						GetComponent<TextMesh> ().text = "Hey, take a look outside, its really nice out today.";
						if (Input.anyKeyDown) {
								currentStep = 7;
								fanSpeedMod = 75;
								Vector3 lookOutWindow = GameObject.Find ("BackgroundBldg17").transform.position;
								GameObject.Find ("Main Camera").transform.position = new Vector3 (-7, 6, -20);
								GameObject.Find ("Main Camera").transform.LookAt (lookOutWindow);
								GameObject.Find ("duckfaceMoon").rigidbody.useGravity = true;
						}					
				} else if (currentStep == 7) {

						if (Input.anyKeyDown) {
								Vector3 origViewLook = GameObject.Find ("ceilingFan").transform.position;
								currentStep = 8;
								fanSpeedMod = 75;
								GameObject.Find ("Main Camera").transform.position = new Vector3 (14, 0, -18);
								GameObject.Find ("Main Camera").transform.LookAt (origViewLook);
						}
				} else if (currentStep == 8) {	
						GetComponent<TextMesh> ().text = "...oh.";
	
						if (Input.anyKeyDown) {
								currentStep = 9;
								fanSpeedMod = 75;
						}
				} else if (currentStep == 9) {
						GetComponent<TextMesh> ().text = "Maybe not.";		
						if (Input.anyKeyDown) {
							currentStep = 10;
							fanSpeedMod = 305;
							GameObject.Find ("ceilingFan").rigidbody.useGravity = true;
					}
				}
		
		
	} // closes out Update (), from line 18

} // closes out the class declaration, from line 4







