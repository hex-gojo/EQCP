using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class jumpbreakertrg : MonoBehaviour {

	void OnTriggerEnter(Collider other){
		Debug.Log ("aaaa");
		SceneManager.LoadScene ("Event1");
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
