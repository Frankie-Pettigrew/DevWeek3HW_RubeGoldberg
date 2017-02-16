using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collision1 : MonoBehaviour {
	public GameObject camera1;
	public GameObject camera2;

	public Collider collider1;


	// Use this for initialization
	void Start () {
		camera1.SetActive(true); 
		camera2.SetActive(false);

	}

	// Update is called once per frame
	void OnTriggerExit(Collider collider1) {
		camera1.SetActive (false);
		camera2.SetActive (true);
	}
}
