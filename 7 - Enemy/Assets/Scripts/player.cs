using UnityEngine;
using System.Collections;

public class player : MonoBehaviour                   //  Attached to 'GoodGuy1'
{
	public Vector3 startPosition;
	public float speed = 20f;
	public float gravity = 20.0f;
	//private Vector3 moveDirection = Vector3.zero;
	public GameObject projectile;                                                              //  projectile is referenced from the 'projectile' script

	void Start () {
		startPosition = transform.position;
	}

	 void Update() {
	//	CharacterController controller = GetComponent<CharacterController>();
	//	if (controller.isGrounded) {
	//		moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
	//		moveDirection *= speed;			
	//	}

	//	if (Input.GetAxisRaw("Horizontal") == -1) {
	//		transform.rotation = (Quaternion.Euler (0, 0f, 0));
	//	}
	//	if (Input.GetAxisRaw ("Horizontal") == 1) {
	//		transform.rotation = (Quaternion.Euler (0f,  180f, 0));
	//	}
	//	if (Input.GetAxisRaw ("Vertical") == -1) {
	//		transform.rotation = (Quaternion.Euler(0, 270f, 0));
	//	}
	//	if (Input.GetAxisRaw ("Vertical") == 1) {
	//		transform.rotation = (Quaternion.Euler (0,  90f, 0));
	//	}

	//	moveDirection.y -= gravity * Time.deltaTime;                    
	//	controller.Move(moveDirection * Time.deltaTime);

		if (Input.GetKeyDown (KeyCode.Space)) {                                                  //  Spacebar shoots player projectiles
			GameObject clone;
			clone = Instantiate (projectile, transform.position, transform.rotation) as GameObject;
			clone.GetComponent<projectile>().target = null;
			Physics.IgnoreCollision(clone.GetComponent<Collider>(), GetComponent<Collider>());
		}
	
	 }

	void FixedUpdate (){                                                                         //  Movement for Player
		                                                                                         //  Player will rotate to new direction as opposed to instantanous switch 90 or 180 degrees
		var move = new Vector3 (Input.GetAxis ("Horizontal"), 0, Input.GetAxis ("Vertical"));

		if (Input.GetAxis ("Horizontal") != 0 || Input.GetAxis ("Vertical") != 0) {
			GetComponent <Rigidbody> ().position += move * speed * Time.deltaTime;
			transform.forward = new Vector3 (Input.GetAxis ("Horizontal"), 0, Input.GetAxis ("Vertical"));
		}
	}
}

