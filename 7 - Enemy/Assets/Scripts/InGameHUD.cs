using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class InGameHUD : MonoBehaviour {
	private int health = 100;
	private int coins = 0;
	private int score = 0;
	public Slider healthBar;

	void Start()
	{
		EventDB.isOver = false;
	}
	public void EnemyDeath(GameObject gameobject)
	{
		score ++;
		Destroy (gameobject);

		if (score >= 3)
			EventDB.WinCondition ();
	}

	public void PlayerTakesDamage (int dmg)
	{
		healthBar.value -= dmg;
		//Start your fade coroutine here

		if (healthBar.value == 0)
			EventDB.WinCondition ();
	}

	//Make you color fade coroutine here
	//Instead of color.a, use a Color.Lerp


}
