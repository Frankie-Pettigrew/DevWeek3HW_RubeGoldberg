using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collision2 : MonoBehaviour {
	public GameObject camera2;
	public GameObject camera3;

	public Collider collider2;

	// Use this for initialization
	void Start () {
		camera3.SetActive (false);
	}
	
	// Update is called once per frame
	void OnTriggerEnter (Collider collider2) {
		camera2.SetActive (false);
		camera3.SetActive (true);
	}
}
