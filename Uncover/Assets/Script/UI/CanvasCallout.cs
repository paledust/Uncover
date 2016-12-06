using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class CanvasCallout : MonoBehaviour {
	public Image[] imageUIs;
	public Button[] buttons;
	public float apSpeed;
	public float alpha;

	private bool ifFading;
	private bool ifComplete;
	private Color fadeColor;
	// Use this for initialization
	void Start () {
		imageUIs = new Image[transform.childCount];
		buttons = new Button[transform.childCount];
		fadeColor = new Color (1, 1, 1, 0);
		alpha = 0.0f;

		for (int i = 0; i < transform.childCount; i++) {
			imageUIs [i] = transform.GetChild (i).GetComponent<Image>();
			buttons [i] = transform.GetChild (i).GetComponent<Button> ();
		}

		foreach(Image element in imageUIs)
		{
			element.color = fadeColor;
		}

		foreach(Button element in buttons)
		{
			element.interactable = false;
		}
	}
	
	// Update is called once per frame
	void Update () {
		alpha = imageUIs [0].color.a;
		if (Input.GetButton ("Fire2") && !ifComplete) {
			ifFading = false;
			CallOn ();
		}

		if (Input.GetButtonUp ("Fire2")) {
			ifComplete = false;
			ifFading = true;
		}

		if (ifFading)
			FadeOut ();
		
		ColorJust ();
	
	}

	//Call the UI and Active the Button
	public void CallOn()
	{
		foreach (Image element in imageUIs) {
			element.color = Color.Lerp (element.color, Color.white, Time.deltaTime * 3.0f);
		}	

		foreach(Button element in buttons)
		{
			if(!element.interactable)
				element.interactable = true;
		}

	}

	//Fade the UI and deactive the Button
	public void FadeOut()
	{
		foreach (Image element in imageUIs) {
			element.color = Color.Lerp (element.color, fadeColor, Time.deltaTime * apSpeed);
		}

		foreach(Button element in buttons)
		{
			if(element.interactable)
				element.interactable = false;
		}
	}

	void ColorJust()
	{
		if (alpha >= 0.99f && !ifFading) {
			ifComplete = true;
			foreach (Image element in imageUIs) {
				element.color = Color.white;
			}	
		}

		if (alpha <= 0.01f && ifFading) {
			ifFading = false;
			foreach (Image element in imageUIs) {
				element.color = fadeColor;
			}	
		}
	}
		
}
