using UnityEngine;
using System.Collections;

public class AI : MonoBehaviour {                //  Attached to 'BadGuy1' - Enemy

	public float speed = 15f;                    // The moving speed of Enemy is 15f
	public GameObject player;					 // Enemies target
	public float spawnTime = 3f;                 //  New bullet created every 3f
	public GameObject bullet;					// Bullet prefeab
	public GameObject detect;					//Enemies Detect radius object

	void Start () {
		InvokeRepeating ("enemyShoot", 2f, spawnTime); //Repeating shooting
	}

	void Update() {
		if (detect.GetComponent<Detect>().isInRange && player != null) // See if "Detect" found player and if player is still alive
		    {
			transform.LookAt (player.transform);								// Look at the player
			transform.position += transform.forward * speed * Time.deltaTime;	// Move forward
		}
	}

	void enemyShoot()
	{
		if (detect.GetComponent<Detect> ().isInRange && player != null) 							//See if "Detect" found the player 
		{
			GameObject clone;																		//Make clone variable
			clone = (Instantiate (bullet, transform.position, transform.rotation)) as GameObject;	//Instantiate bullet
			clone.GetComponent<projectile>().target = player;
			Physics.IgnoreCollision (clone.GetComponent<Collider> (), GetComponent<Collider> ());	//Ingore enemy's collider
		}
	}
}
