using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using System.Collections;

public class ModalPanel : MonoBehaviour {

	public Text question;
	public Button yesButton;
	public Button noButton;
	public GameObject modalPanelObject;

	private static ModalPanel modalPanel;

	public static ModalPanel Instance () 
	{
			if (!modalPanel) 
		    {
				modalPanel = FindObjectOfType (typeof(ModalPanel))as ModalPanel;
		
				if (!modalPanel)
				Debug.LogError ("There needs to be one active ModalPanel script on a GameObject in you scene.");
			}

			return modalPanel;
	}

	// Yes/No/Cancel: A string, a Yes event, a No event and Cancel event

	public void Choice (string question, UnityAction yesEvent, UnityAction noEvent)
	{
		modalPanelObject.SetActive (true);

		yesButton.onClick.RemoveAllListeners();
		yesButton.onClick.AddListener (yesEvent);
		yesButton.onClick.AddListener (ClosePanel);

		noButton.onClick.RemoveAllListeners();
		noButton.onClick.AddListener (noEvent);
		noButton.onClick.AddListener (ClosePanel);

		this.question.text = question;

	}

	void ClosePanel ()
	{
		modalPanelObject.SetActive (false);
	}
}
