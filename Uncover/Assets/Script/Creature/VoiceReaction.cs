using UnityEngine;
using System.Collections;

public class VoiceReaction : MonoBehaviour {
	public float reactionTime = 0.5f;

	private string receiveWord;
	private EarDetection earDetection;
	private SymbolStock symbolStock;
	private CanvasCallout_Creature creatureUI;
	private Decode decode;

	virtual protected void Start()
	{
		symbolStock = GetComponentInChildren<SymbolStock> ();
		creatureUI = transform.parent.GetComponentInChildren<CanvasCallout_Creature> ();
		decode =  transform.parent.GetComponentInChildren<Decode> ();
	}

	virtual public void reaction(string m_receiveWord)
	{
		receiveWord = m_receiveWord;
		Invoke ("speak",reactionTime);
	}

	void speak()
	{
		transform.parent.GetComponentInChildren<Speak> ().saySymbol (receiveWord);
		PutintoStock ();
		ShowSymbol ();
	}

	void PutintoStock()
	{
		symbolStock.AddSymbol (receiveWord);
	}

	void ShowSymbol()
	{
		creatureUI.CallOn ();
	}

	void ShowOneSymbol()
	{
	}
}
