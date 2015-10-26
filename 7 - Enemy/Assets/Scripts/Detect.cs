using UnityEngine;
using System.Collections;

public class Detect : MonoBehaviour {

	public bool isInRange;
	// Use this for initialization
	void Start () {
	
	}
	
	void OnTriggerEnter(Collider other) {
		if (other.tag == "Player")
						isInRange = true;
	}

	void OnTriggerExit(Collider other) {
		if (other.tag == "Player")
						isInRange = false;
	}
}
