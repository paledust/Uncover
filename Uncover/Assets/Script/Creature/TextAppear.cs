using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TextAppear : MonoBehaviour {
	public Image imageUI;
	public float apSpeed;
	public float alpha;
	public bool ifOn;
	public bool ifOff;
    public Color StartColor;
    public Color fadeColor;


    private bool ifCall;
	private bool ifFadeout;
	// Use this for initialization
	void Start () {
		ifOff = true;
		ifOn = false;

		alpha = 0.0f;
		ifCall = false;
		imageUI = GetComponent<Image> ();
		imageUI.color = fadeColor;
	}

	// Update is called once per frame
	void Update () {
		alpha = imageUI.color.a;

		if (ifCall && alpha < 1.0f) {
			ShowUI ();
		}

		if (ifFadeout && alpha > 0.0f) {
			FadeOut ();
		}
	}

	public void CallOn()
	{
		ifCall = true;
		ifFadeout = false;
		ifOff = false;
	}

	public void CallFade()
	{
		ifFadeout = true;
		ifCall = false;
		ifOn = false;
	}

	void ShowUI()
	{
		imageUI.color = Color.Lerp (imageUI.color, StartColor, Time.deltaTime * apSpeed);
		if (imageUI.color.a >= 0.99f) {
			imageUI.color = StartColor;
			ifOn = true;
		}
	}

	void FadeOut()
	{
		imageUI.color = Color.Lerp (imageUI.color, fadeColor, Time.deltaTime * apSpeed);
		if (imageUI.color.a <= 0.01f) {
			imageUI.color = fadeColor;
			imageUI.sprite = null;
			ifOff = true;
		}
	}

	public void SetSprite(Sprite m_word)
	{
		imageUI.sprite = m_word;
	}
}
