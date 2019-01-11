using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class jumpshelftrg : MonoBehaviour {

	void OnTriggerEnter(Collider other){
		Debug.Log (Dataset.breakersceneflag);
		if (Dataset.shelfsceneflag == 0) {
			SceneManager.LoadScene ("Shelf");
			Dataset.shelfsceneflag = 1;
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
