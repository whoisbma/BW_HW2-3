using UnityEngine;
using System.Collections;

public class FanRotate : MonoBehaviour {

	int speed = 75;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate(Vector3.up * Time.deltaTime * speed);
		//GetComponent<Transform> ().position += new Vector3 (0f, 1f, 0f);
		//transform.position += new Vector3 (0f, -0.1f, 0f);

		speed = GameObject.Find("New Text").GetComponent<HelloWorld>().fanSpeedMod;

	}
}