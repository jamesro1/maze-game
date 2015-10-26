using UnityEngine;
using System.Collections;

public class EnemyProjectileScript : MonoBehaviour {         //  Attached to 'BadGuy1' because the is the projectile that he shoots

	//public Vector3 projectileOrigen;                         //  Need this variable for the function that sets the Projectile origen
	//public float speed;                                      //  To be the speed of the projectile which will be set in the Inspector panel
	//public float distance;                                   //  Will be the distance before the projectile dies, otherwise all of them will continue to move as long as the game runs
	                                                           
	                                            

	void Start () {                                           //  void - keyword, Start - identifier, Projectile will originate at 'BadGuy1' since that is where the script is attached

	}
	
	/*                                                       // void - keyword, Update - identifier, update is called once per frame
	void Update () 
	{
		distance = Vector3.Distance(projectileOrigen, transform.position);
		if (distance >= 90f)                                 //  The projectile dies at the distance of 90f
		Destroy (gameObject);                                //  Determines that the projectile dies

		transform.position += transform.forward * speed;
	}
	*/                                                       //  OnTriggerEnter is called when the Collider other enters the trigger.
	                                    

	
	void OnTriggerEnter(Collider other) {                    //  void - keyword, OnTriggerEnter - identifier, (Collider - base class of all Colliders, other - )                 
		if (other.tag == "Player") {
						Debug.Log ("Im dead");
						Destroy (other.gameObject);                      //  The object will be destroyed now
						Destroy (this.gameObject);
				}
	}
}
