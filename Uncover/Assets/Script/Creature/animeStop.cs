using UnityEngine;
using System.Collections;

public class animeStop : MonoBehaviour {
    private Animator anime;

    void Start()
    {
        anime = GetComponent<Animator>();
    }

    public void AnimeStop()
    {
        anime.SetBool("ifTalking", false);
    }
}
