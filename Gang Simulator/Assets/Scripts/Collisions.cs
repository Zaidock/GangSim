using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Collisions : MonoBehaviour {

	void OnTriggerEnter(Collider collider){
		Debug.Log ("ENTERING Hotel");
		SceneManager.LoadScene ("Hotel");
	}
}
