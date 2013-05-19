using UnityEngine;
using System.Collections;

public class TeleportToLevel1 : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	void OnTriggerEnter(Collider other) {
        Application.LoadLevel("level1");
    }
}
