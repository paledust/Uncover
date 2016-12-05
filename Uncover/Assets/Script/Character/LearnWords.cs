using UnityEngine;
using System.Collections;

public class LearnWords : MonoBehaviour {
    public GameObject symbolManager;

    public void learnword(int i)
    {
        if (!symbolManager.transform.GetChild(i).gameObject.activeSelf)
            symbolManager.transform.GetChild(i).gameObject.SetActive(true);
    }
}
