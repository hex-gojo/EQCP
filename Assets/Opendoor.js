#pragma strict

var isNear : boolean;
var animator : Animator;

function Start () {
	isNear = false;
	animator = transform.parent.GetComponent<Animator>();
}

function Update () {
	if(Input.GetKeyDown("e") && isNear) {
		animator.SetBool ("Open", !animator.GetBool ("Open"));
	}
}

function OnTriggerEnter(Collider col) {
	if(col.tag == "Player") {
		isNear = true;
	}
}

function OnTriggerExit(Collider col) {
	isNear = false;
}