using UnityEngine;
using System.Collections;

public class AI : MonoBehaviour {                //  Attached to 'BadGuy1' - Enemy
	public Transform target;
	public float speed = 15f;                    // The moving speed of Enemy is 4f
	public GameObject player;
	public float spawnTime = 3f;                 //  New bullet created every 3f
	public int minrange = 10;
	public GameObject enemy;
	public bool chase = false;
	public int shotCount;
	public int total = 1;
	public GameObject bullet;

	// Use this for initialization
	void Start () {

			target = player.transform;
	}
	                                                            // Update is called once per fram
	void Update() {

			distanceCheck ();
		if (chase == true)
		    {
			enemy.transform.LookAt (target);
			transform.position += transform.forward * speed * Time.deltaTime;
			enemyShoot ();
		}
	}

	void distanceCheck()
	{
		if (Vector3.Distance (transform.position, target.position) <= minrange) 
		{
			chase = true;
		} 
		else 
		{
			chase = false;
		}


	}

	                                                                                                   //  Coroutine 
	void enemyShoot()
	{
		shotCount++;
		if (shotCount <= total)
			StartCoroutine (waitToShoot ());

		}
                                                                                                        //  Enemy shooting
	IEnumerator waitToShoot ()
	{
		Debug.Log ("waitToShoot");
		GameObject clone;
		clone = (Instantiate (bullet, transform.position, transform.rotation)) as GameObject;
		clone.GetComponent <Rigidbody> ().AddForce (transform.forward * 1000);
		enemyShoot ();
		yield return new WaitForSeconds (3);
		shotCount = 0;
	}


}
