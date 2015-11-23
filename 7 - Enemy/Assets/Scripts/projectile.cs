using UnityEngine;
using System.Collections;

public class projectile : MonoBehaviour {

	public Vector3 projectileOrigen;
	public float speed;
	public float distance;

	void Start () {
		projectileOrigen = transform.position;
	}	
	                                                                            // Update is called once per frame
	void Update ()                                                              //  Once the projectile travels 90f it dies
	{
	 distance = Vector3.Distance(projectileOrigen, transform.position);
	 if (distance >= 90f)
		Destroy (gameObject);

		transform.position += transform.forward * speed;
	}
	                                                                            // Players projectile destroys the Enemy
	void OnCollisionEnter(Collision other) 
	{
	if (other.transform.tag == "Enemy") 
		{
			// GameObject.Find ("Canvas").transform.FindChild("Buttons").gameObject.SetActive(true);
			Destroy (other.gameObject);
		}
	Destroy (this.gameObject);

	}
}
