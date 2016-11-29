using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class CanvasCallOut_Screen : MonoBehaviour {
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
		ifFading = false;
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

	// Update is called once per frame-----------------------------------
	void Update () {
		alpha = imageUIs [0].color.a;
		if (ifFading)
			FadeOut ();
	}
	//Update End --------------------------------------------------------

	//Call the UI and Active the Button
	public void CallOn()
	{
		ifFading = false;
		foreach (Image element in imageUIs) {
			element.color = Color.Lerp (element.color, Color.white, Time.deltaTime * apSpeed);
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
		if (alpha <= 0.1f) {
			Destroy (gameObject);
		}	
	}

	public void startFade()
	{
		ifFading = true;
	}

}
