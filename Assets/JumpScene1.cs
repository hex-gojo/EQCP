using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class JumpScene1 : MonoBehaviour {

	public void JumpScene() {
		Dataset.score += 1;
		SceneManager.LoadScene ("Main");
	}
}
