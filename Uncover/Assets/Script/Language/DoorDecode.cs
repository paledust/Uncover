using UnityEngine;
using System.Collections;

public class DoorDecode : Decode {
    public string keyWords;

    private void OpentheDoor(string code)
    {
        if (code == keyWords)
        {
            Debug.Log("Approve");
            gameObject.SetActive(false);
        }
    }

    public override Sprite[] BreakCode(string m_words)
    {
        string answerTemp;
        if (!diction.TryGetValue(m_words, out answerTemp))
        {
            return null;
        }

        OpentheDoor(m_words);
        string[] temp = new string[answerTemp.Length];

        for (int i = 0; i < answerTemp.Length; i++)
        {
            temp[i] = answerTemp[i].ToString();
        }

        Sprite[] tempSprite = new Sprite[temp.Length];

        string answer = "The Answer is:";

        for (int i = 0; i < temp.Length; i++)
        {
            answer = answer + temp[i];
            LearnWords(temp[i]);
        }

        for (int i = 0; i < temp.Length; i++)
        {
            tempSprite[i] = decodeWords(temp[i]);
        }

        Debug.Log(answer);
        return tempSprite;
    }
}
