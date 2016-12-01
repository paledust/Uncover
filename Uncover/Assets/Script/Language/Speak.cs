using UnityEngine;
using System.Collections;

public class Speak : MonoBehaviour {
	public bool ifSpeaking;
	public float speakingTime;
	public string currentWord;

	private float timer;

	void Start()
	{
		timer = 0.0f;
		ifSpeaking = false;
		currentWord = null;
	}

	void Update()
	{
		timer += Time.deltaTime;

		if (timer >= speakingTime && ifSpeaking) {
			ifSpeaking = false;
			currentWord = null;
		}
	}

	public void saySymbol(string m_symbol)
	{
		timer = 0.0f;
		currentWord = m_symbol;
		ifSpeaking = true;
	}
}
