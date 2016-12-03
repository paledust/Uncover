using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CreatureCallUI : MonoBehaviour {
	public TextAppear[] textAppears;

	// Use this for initialization
	void Start () {
		textAppears = new TextAppear[transform.childCount];
		for (int i = 0; i < transform.childCount; i++) {
			textAppears [i] = transform.GetChild (i).GetComponent<TextAppear> ();
		}
	}

	public void CallOneOn(int i, Sprite m_word)
	{
		textAppears [i].SetSprite (m_word);
		textAppears [i].CallOn ();
	}

	public void FadeAll()
	{
		foreach (TextAppear text in textAppears) {
			text.CallFade ();
		}
	}

	public bool ifFadeAll()
	{
		foreach (TextAppear text in textAppears) {
            if (text.alpha!=0.0f)
            {
                return false;
            }
		}
		return true;
	}

	public bool ifOnAll()
	{
		foreach (TextAppear text in textAppears) {
			if (text.ifOn)
				return true;
		}

		return false;
	}
}
