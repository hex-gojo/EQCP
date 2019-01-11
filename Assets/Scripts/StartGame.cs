using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour {

	public void GameStart() {
		SceneManager.LoadScene ("Main");
	}

	// Use this for initialization
	void Start () {
		Dataset.breakersceneflag = 0;	//ブレーカー遷移フラグ
		Dataset.stovesceneflag = 0;	//コンロ遷移フラグ
		Dataset.mirrorsceneflag = 0;	//鏡遷移フラグ
		Dataset.shelfsceneflag = 0;	//棚遷移フラグ
		Dataset.tablesceneflag = 0;	//机遷移フラグ
		Dataset.score = 0;	//評価結果
		Dataset.playerX = 9;	// プレイヤー: X座標
		Dataset.playerY = 0;	// プレイヤー: Y座標
		Dataset.playerZ = 2;	// プレイヤー: Z座標
		Dataset.Rotation = 0;	// プレイヤー: Y軸回転角度
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
