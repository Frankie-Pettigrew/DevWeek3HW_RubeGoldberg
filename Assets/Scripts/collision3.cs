using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class collision3 : MonoBehaviour {
	public GameObject camera3;
	public GameObject camera4;

	public Collider collider3;
	public Text text;

	// Use this for initialization
	void Start () {
		camera4.SetActive (false);
		text.text = "";
	}
	
	// Update is called once per frame
	void OnTriggerEnter (Collider collider3) {
		camera4.SetActive (true);
		text.text = "You won the guy";
	}
}
