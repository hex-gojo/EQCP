using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dataset : MonoBehaviour {
	
	public static int breakersceneflag = 0;	//ブレーカー遷移フラグ
	public static int stovesceneflag = 0;	//コンロ遷移フラグ
	public static int mirrorsceneflag = 0;	//鏡遷移フラグ
	public static int shelfsceneflag = 0;	//棚遷移フラグ
	public static int tablesceneflag = 0;	//机遷移フラグ

	public static int score = 0;	//評価結果

	public static float playerX = 9;
	public static float playerY = 0;
	public static float playerZ = 2;

	public static float Rotation = 0;





	// Use this for initialization
	void Start () {
		GameObject.Find ("PQchan").transform.position = new Vector3 (playerX, playerY ,playerZ);
		GameObject.Find ("PQchan").transform.localEulerAngles = new Vector3 (0, Rotation ,0);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
