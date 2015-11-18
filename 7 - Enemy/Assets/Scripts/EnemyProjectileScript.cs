using UnityEngine;
using System.Collections;

public class EnemyProjectileScript : MonoBehaviour {         //  Attached to 'BadGuy1' because the is the projectile that he shoots

	public Vector3 projectileOrigen;                         //  Need this variable for the function that sets the Projectile origen
	public float speed;                                      //  To be the speed of the projectile which will be set in the Inspector panel
	public float distance;                                   //  Will be the distance before the projectile dies, otherwise all of them will continue to move as long as the game runs

	void Start () 
	{                                           // Projectile will originate at 'BadGuy1' since that is where the script is attached
		projectileOrigen = transform.position;
	}
	
                                                    
	void Update () 
	{
		distance = Vector3.Distance(projectileOrigen, transform.position);
		if (distance >= 90f)                                 				//  The projectile dies at the distance of 90f
			Destroy (gameObject);                               			 //  Determines that the projectile dies

		transform.position += transform.forward * speed;
	}                                                    
	                                    

	
	void OnCollisionEnter(Collision other) {            //  Detect if colliding if anything )                 
		if (other.transform.tag == "Player") 
				{
						GameObject.Find ("Canvas").transform.FindChild("Buttons").gameObject.SetActive(true);
						Destroy (other.gameObject);     //  The object will be destroyed now
				}
		Destroy (gameObject);							// Destroys when it hits anything
	}
}
