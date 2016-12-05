using UnityEngine;
using System.Collections;

public class VoiceReaction : MonoBehaviour {
	public float reactionTime = 0.5f;
	public float waitTime = 3.0f;

	private bool ifListening;
	private string receiveWord;
	private bool isWaiting;
	private SymbolStock symbolStock;
	private CreatureCallUI creatureUI;
	private Decode decode;
    private bool ifAnswer;
	private float timer;

	protected void Start()
	{
		ifListening = true;
		isWaiting = false;
        ifAnswer = false;
        symbolStock = GetComponentInChildren<SymbolStock> ();
		creatureUI = transform.parent.GetComponentInChildren<CreatureCallUI> ();
		decode =  transform.parent.GetComponentInChildren<Decode> ();
	}

// Update-------start
	void Update()
	{
		listenRest ();

        if (!isWaiting && !ifListening && !ifAnswer && creatureUI.ifFadeAll())
        {
            Answer();
            ifAnswer = true;
            ifListening = false;
        }

		if (isWaiting && timer <= waitTime) {
			timer += Time.deltaTime;
		}
		else if (isWaiting) {
			isWaiting = false;
			ifListening = false;
			FadeAllSymbol ();
			timer = 0.0f;
		}
	}
// Update-------End

	virtual public void reaction(string m_receiveWord)
	{
		timer = 0.0f;
		receiveWord = m_receiveWord;
		if (ifListening) {
			Invoke ("speak",reactionTime);	
		}
	}

	void speak()
	{
		isWaiting = true;
		transform.parent.GetComponentInChildren<Speak> ().saySymbol (receiveWord);
		ShowOneSymbol (symbolStock.getOrder(),decode.decodeWords(receiveWord));
		PutintoStock ();
	}

	void PutintoStock()
	{
		symbolStock.AddSymbol (receiveWord);
	}

	void ShowOneSymbol(int i, Sprite m_word)
	{
		creatureUI.CallOneOn (i, m_word);
	}

	void FadeAllSymbol()
	{
		creatureUI.FadeAll ();
        ifAnswer = false;
    }

    void FadeAndReset()
    {
        creatureUI.FadeAll();

        ifListening = true;
        isWaiting = false;
        ifAnswer = false;
    }

	void listenRest()
	{
		if (creatureUI.ifFadeAll () && !ifListening && ifAnswer) {
			ifListening = true;
		}
	}

    void Answer()
    {
        Sprite[] tempSprite = decode.BreakCode(symbolStock.MergeSymbol());
        if (tempSprite != null)
        {
            for (int i = 0; i < tempSprite.Length; i++)
            {
                creatureUI.CallOneOn(i, tempSprite[i]);
            }
            transform.parent.GetComponentInChildren<Speak>().saySymbol(receiveWord);
            Invoke("FadeAndReset", 2.0f);
        }
        else
        {
            FadeAndReset();
        }
        symbolStock.CleanWords();
    }

    public bool getifAnswer()
    {
        return ifAnswer;
    }
}
