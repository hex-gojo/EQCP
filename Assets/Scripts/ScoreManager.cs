using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {

	public GameObject score_object = null;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Text Score_text = score_object.GetComponent<Text> ();
		Score_text.text = "評価点 : " + Dataset.score + " / 5 点";
	}
}
