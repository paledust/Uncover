using UnityEngine;
using System.Collections;

public class SymbolStock : MonoBehaviour {
	public string[] symbolSave;
	public float waitTime;

	private int i;
	private float timer;
	private bool ifCounting;
	// Use this for initialization
	void Start () {
		i = 0;
		timer = 0.0f;
		ifCounting = false;
	}

	void Update()
	{
		ThinkWord ();
	}
	
	public void AddSymbol(string m_words)
	{
		symbolSave [i] = m_words;
		i++;
		if (i >= symbolSave.Length) {
			i = 0;
		}
		ifCounting = true;
		timer = 0.0f;
	}

	void ThinkWord()
	{
		if (ifCounting && timer <= waitTime) {
			timer += Time.deltaTime;
		}
		else if (ifCounting) {
			ifCounting = false;
			for (int j = 0; j < symbolSave.Length; j++) {
				symbolSave [j] = null;
			}
			i = 0;
			timer = 0.0f;
		}
	}
}
