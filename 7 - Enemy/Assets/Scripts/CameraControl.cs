using UnityEngine;
using System.Collections;

public class CameraControl : MonoBehaviour {
	public GameObject target;

	
	                     // Update is called once per frame
	                     //  Makes the camera follow the player
	void Update () {
		if(target != null)
			transform.position = new Vector3 (target.transform.position.x, transform.position.y, target.transform.position.z);
	}
}
