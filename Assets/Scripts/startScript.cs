using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startScript : MonoBehaviour {
	public GameObject startTrigger;
	// Use this for initialization
	void Start () {
		startTrigger.SetActive (true);
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.Space)) {
			startTrigger.SetActive (false);
		}
	}
}
