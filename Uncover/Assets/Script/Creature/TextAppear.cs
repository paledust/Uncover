using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TextAppear : MonoBehaviour {
	public Image imageUI;
	public float apSpeed;
	public float alpha;
	public float FadeTime = 1.0f;

	private bool ifCall;
	private bool ifComplete;
	private Color fadeColor;

	private float timer;
	// Use this for initialization
	void Start () {
		fadeColor = new Color (1, 1, 1, 0);
		alpha = 0.0f;
		ifCall = false;
		imageUI = GetComponent<Image> ();
		imageUI.color = fadeColor;

		timer = 0.0f;
	}

	// Update is called once per frame
	void Update () {
		alpha = imageUI.color.a;

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

	public void CallOnAll()
	{
		ifCall = true;
	}

	void ShowUI()
	{
		imageUI.color = Color.Lerp (imageUI.color, Color.white, Time.deltaTime * apSpeed);
	}

	public void FadeOut()
	{
		imageUI.color = Color.Lerp (imageUI.color, fadeColor, Time.deltaTime * apSpeed);
	}
}
