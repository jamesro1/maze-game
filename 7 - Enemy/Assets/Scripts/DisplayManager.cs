﻿using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using System.Collections;

public class DisplayManager : MonoBehaviour {
	
	public Text displayText;
	public float displayTime;
	public float fadeTime;
	
	private IEnumerator fadeAlpha;
	
	private static DisplayManager displayManager;
	
	public static DisplayManager Instance () 
	{
		if (!displayManager) {
			displayManager = FindObjectOfType (typeof(DisplayManager)) as DisplayManager;
			if (!displayManager)
				Debug.LogError ("There needs to be one active DisplayManager script on a GameObject in your scene.");
		}
		
		return displayManager;
		
	}
	
	public void DisplayMessage (string message)
	{
		displayText.text = message;
		SetAlpha ();
	}
	
	void SetAlpha () 
	{
		if (fadeAlpha != null)
		{
			StopCoroutine (fadeAlpha);
		}

	fadeAlpha = FadeAlpha ();
	StartCoroutine (fadeAlpha);
}

	IEnumerator FadeAlpha ()
	{
		Color resetColor = displayText.color;
		resetColor.a = 1;
		displayText.color = resetColor;

		yield return new WaitForSeconds (displayTime);



	
	}
}