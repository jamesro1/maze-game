using UnityEngine;
using System.Collections;

public class Entity :  MonoBehaviour
{
	public bool noaStuipdWall;
	public void Death ()
	{
		Destroy (gameObject);
	}
	public void Damage (int dmg)
	{
		if (gameObject.tag == "Enemy")
			EventDB.Death (this.gameObject);
		else if (gameObject.tag == "Player")
			EventDB.TakeDamage (this.gameObject, dmg);
	}

	void Update()
	{
		if (EventDB.isOver)
			Destroy (this.gameObject);
	}
}

