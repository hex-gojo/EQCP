using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class jumpstovetrg : MonoBehaviour {

	void OnTriggerEnter(Collider other){
		Debug.Log (Dataset.breakersceneflag);
		if (Dataset.stovesceneflag == 0) {
			SceneManager.LoadScene ("Stove");
			Dataset.stovesceneflag = 1;
			Vector3 tmp = GameObject.Find ("PQchan").transform.position;
			Dataset.playerX = tmp.x;
			Dataset.playerZ = tmp.z;
			tmp = GameObject.Find ("PQchan").transform.localEulerAngles;
			Dataset.Rotation = tmp.y;
		}
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
