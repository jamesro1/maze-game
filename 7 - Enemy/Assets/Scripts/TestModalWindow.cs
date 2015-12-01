using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using System.Collections;

public class TestModalWindow : MonoBehaviour {

	private ModalPanel modalPanel;
	private DisplayManager displayManager;

	private UnityAction myYesAction;
	private UnityAction myNoAction;


	void Awake ()
	{
		modalPanel = ModalPanel.Instance ();
		displayManager = DisplayManager.Instance ();

		myYesAction = new UnityAction (TestYesFunction);
		myNoAction = new UnityAction (TestNoFunction);

	}

//  Send to the Modal Panel to set up the Buttons and Functions to call

	public void TestYNC ()
	{
		modalPanel.Choice ("Want to play Again?", myYesAction, myNoAction);
		displayManager.SetAlpha ();
	}
		                                   
//  These are wrapped into UnityActions

	void TestYesFunction ()
	{
		Application.LoadLevel (1);
	}
	void TestNoFunction ()
	{
		Application.LoadLevel (0);
	}


	
	
}
