using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using System.Collections;

public class projectile : MonoBehaviour
{
		public Vector3 projectileOrigen;
		public float speed;
		public float distance;
		public GameObject target;
		public int damage;

		void Start ()
		{
				projectileOrigen = transform.position;
		}	
		// Update is called once per frame
		void Update ()                                                              //  Once the projectile travels 90f it dies
		{
				distance = Vector3.Distance (projectileOrigen, transform.position);
				if (distance >= 90f)
						Destroy (gameObject);
				transform.position += transform.forward * speed;
		}

		// Players projectile destroys the Enemy
		void OnCollisionEnter (Collision other)
		{ 
				if (target != null) {
						if (other.transform.gameObject == target) {
							other.gameObject.GetComponent<Entity>().Damage(damage);
						}	
				} 
				else 
				{
						if (other.transform.tag == "Enemy")
							other.gameObject.GetComponent<Entity>().Damage(damage);			
				}		
		Destroy (gameObject);
	}	
}





