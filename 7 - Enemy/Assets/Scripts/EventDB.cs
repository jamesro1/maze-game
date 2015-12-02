using UnityEngine;
using System.Collections;

	public static class EventDB
{
			public static bool isOver = false;
		
				//Positive numbers are damage, negative numbers are heals
					public static void TakeDamage (GameObject entity, int dmg)
		{
					if (entity.tag == "Player") 
					{
							GameObject.Find ("Canvas").GetComponent<InGameHUD> ().PlayerTakesDamage(dmg);
						}
				}
		
				public static void Death (GameObject gameObject)
			{
					if (gameObject.tag == "Enemy")
							GameObject.Find ("Canvas").GetComponent<InGameHUD> ().EnemyDeath (gameObject);
				}
		
				public static void WinCondition ()
			{
					GameObject.Find ("Canvas").GetComponent<TestModalWindow> ().TestYNC ();
					isOver = true;
				}
		}
