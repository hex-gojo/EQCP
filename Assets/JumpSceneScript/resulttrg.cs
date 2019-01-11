using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class resulttrg : MonoBehaviour {

	void OnTriggerEnter(Collider other){
			SceneManager.LoadScene ("Result");
			Vector3 tmp = GameObject.Find ("PQchan").transform.position;
			Dataset.playerX = tmp.x + 1;
		Dataset.playerZ = tmp.z;
			tmp = GameObject.Find ("PQchan").transform.localEulerAngles;
			Dataset.Rotation = tmp.y;
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
