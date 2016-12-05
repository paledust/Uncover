using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Decode : MonoBehaviour {
	public static string[] words = {"1", "2", "3", "4", "5", "6", "7"};
	public Sprite[] sprites;

	public string[] questionList;
	public Dictionary<string,string> diction;
	public string[] AnswerList;

    protected GameObject player;

	// Use this for initialization
	protected virtual void Start()
	{
		diction = new Dictionary<string,string>();

		for (int i = 0; i < AnswerList.Length; i++) {
			diction.Add (questionList [i], AnswerList [i]);
		}

        player = GameObject.Find("Bunzu");
    }

	public Sprite decodeWords(string m_word)
	{
		for (int i = 0; i < words.Length; i++) {
			if (m_word == words [i]) {
				return sprites [i];
			}
		}

		return null;
	}

	virtual public Sprite[] BreakCode(string m_words)
	{
		string answerTemp;
		if (!diction.TryGetValue (m_words, out answerTemp)) {
			return null;
		}
		string[] temp = new string[answerTemp.Length];

		for (int i = 0; i < answerTemp.Length; i++) {
			temp [i] = answerTemp [i].ToString();
		}

		Sprite[] tempSprite = new Sprite[temp.Length];

		string answer = "The Answer is:";

		for (int i = 0; i < temp.Length; i++) {
			answer = answer + temp [i];
            LearnWords(temp[i]);
        }

        for (int i = 0; i < temp.Length; i++)
        {
            tempSprite[i] = decodeWords(temp[i]);
        }

        //Debug.Log (answer);
		return tempSprite;
	}

    protected void LearnWords(string word)
    {
        int tempInt;
        tempInt = int.Parse(word);
        Debug.Log(tempInt);
        player.GetComponentInChildren<LearnWords>().learnword(tempInt - 1);
    }
}
