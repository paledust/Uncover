using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SymbolStock : MonoBehaviour {
	public string[] symbolSave;

	private int i;
	private bool ifCounting;
	public string mergedQuestion;
	// Use this for initialization
	void Start () {
		i = 0;
		ifCounting = false;
		mergedQuestion = null;
	}
	
	public void AddSymbol(string m_words)
	{
		symbolSave [i] = m_words;
		i++;
		if (i >= symbolSave.Length) {
			i = 0;
		}
	}

	public void CleanWords()
	{
		for (int j = 0; j < symbolSave.Length; j++) {
			symbolSave [j] = null;
		}
		i = 0;
		mergedQuestion = null;
	}

	public int getOrder()
	{
		return i;
	}

	public bool getCounting()
	{
		return ifCounting;
	}

	public string MergeSymbol()
	{
		foreach (string symbol in symbolSave) {
			mergedQuestion = mergedQuestion + symbol;
		}
		//Debug.Log ("Question is :" + mergedQuestion);

		return mergedQuestion;
	}

	public string getQuestion()
	{
		return mergedQuestion;
	}
}
