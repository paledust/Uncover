using UnityEngine;
using System.Collections;

public class Decode : MonoBehaviour {
	public static string[] words = {"question", "living", "self"};
	public Sprite[] sprites;


	// Use this for initialization

	public Sprite decodeWords(string m_word)
	{
		for (int i = 0; i < words.Length; i++) {
			if (m_word == words [i]) {
				return sprites [i];
			}
		}

		return null;
	}


}
