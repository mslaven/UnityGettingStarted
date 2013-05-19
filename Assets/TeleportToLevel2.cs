using UnityEngine;
using System.Collections;

public class TeleportToLevel2 : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	void OnTriggerEnter(Collider other) {
		audio.Play();
        Application.LoadLevel("level2");
    }
}
