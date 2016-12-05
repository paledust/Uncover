using UnityEngine;
using System.Collections;

public class DoorDecode : Decode {
    public string keyWords;
    public OpenDoorAndFog openDoor;

    override protected void Start()
    {
        base.Start();
        openDoor = GetComponentInParent<OpenDoorAndFog>();
    }

    private void OpentheDoor(string code)
    {
        Debug.Log(code);
        if (code == keyWords)
        {
            Debug.Log("Approve");
            gameObject.SetActive(false);
            openDoor.SetThemUp();
        }
    }

    public override Sprite[] BreakCode(string m_words)
    {
        string answerTemp;
        if (!diction.TryGetValue(m_words, out answerTemp))
        {
            Debug.Log(m_words);
            OpentheDoor(m_words);
            return null;
        }

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
