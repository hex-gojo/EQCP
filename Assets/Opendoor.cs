using UnityEngine;
using System.Collections;

public class OpenDoor : MonoBehaviour {
	
	//　ドアエリアに入っているかどうか
	private bool isNear;
	//　ドアのアニメーター
	private Animator animator;
	
	void Start () {
		isNear = false;
		animator = transform.parent.GetComponent<Animator>();
	}
	
	void Update () {
		if(Input.GetKeyDown("e") && isNear) {
			animator.SetBool ("Open", !animator.GetBool ("Open"));
		}
	}
	
	void OnTriggerEnter(Collider col) {
		if(col.tag == "Player") {
			isNear = true;
		}
	}
	
	void OnTriggerExit(Collider col) {
		isNear = false;
	}
}