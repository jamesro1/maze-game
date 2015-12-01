using UnityEngine;
using System.Collections;

public class Pickup : MonoBehaviour {

	void OnCollisionEnter (Collision other)
	{ 
		//Check if player
		//If so give health
		//Use EventBD.TakeDamage(other.gameobject, # );
		Destroy (gameObject);
	}	
}
