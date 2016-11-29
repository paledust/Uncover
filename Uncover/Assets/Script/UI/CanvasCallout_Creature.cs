using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CanvasCallout_Creature : MonoBehaviour {
	public Image[] imageUIs;
	public float apSpeed;
	public float alpha;
	public float FadeTime = 1.0f;

	private bool ifCall;
	private bool ifComplete;
	private Color fadeColor;

	private float timer;
	// Use this for initialization
	void Start () {
		imageUIs = new Image[transform.childCount];
		fadeColor = new Color (1, 1, 1, 0);
		alpha = 0.0f;
		ifCall = false;
		for (int i = 0; i < transform.childCount; i++) {
			imageUIs [i] = transform.GetChild (i).GetComponent<Image> ();
		}

		foreach(Image element in imageUIs)
		{
			element.color = fadeColor;
		}

		timer = 0.0f;
	}
	
	// Update is called once per frame
	void Update () {
		alpha = imageUIs [0].color.a;

		if (ifCall && alpha < 0.99f) {
			ShowUI ();
		}

		if (alpha >= 0.99f) {
			timer += Time.deltaTime;
		}

		if (alpha <= 0.01f) {
			timer = 0.0f; 
		}

		if (timer >= FadeTime) {
			ifCall = false;
			FadeOut ();
		}
	}

	public void CallOn()
	{
		ifCall = true;
	}

	void ShowUI()
	{
		foreach (Image element in imageUIs) {
			element.color = Color.Lerp (element.color, Color.white, Time.deltaTime * apSpeed);
		}	
	}

	//Fade the UI and deactive the Button
	public void FadeOut()
	{
		foreach (Image element in imageUIs) {
			element.color = Color.Lerp (element.color, fadeColor, Time.deltaTime * apSpeed);
		}
	}
}
