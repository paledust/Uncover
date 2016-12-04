using UnityEngine;
using System.Collections;

public class Speak : MonoBehaviour {
	public bool ifSpeaking;
	public float speakingTime;
	public string currentWord;
    public AudioClip audioClip;

	private float timer;
    private AudioSource audioSource;
    public Animator anime;

	void Start()
	{
		timer = 0.0f;
		ifSpeaking = false;
		currentWord = null;

        audioSource = GetComponent<AudioSource>();
        anime = transform.parent.GetComponentInChildren<Animator>();
    }

	void Update()
	{
		timer += Time.deltaTime;

		if (timer >= speakingTime && ifSpeaking) {
			ifSpeaking = false;
			currentWord = null;
		}
	}

	public void saySymbol(string m_symbol)
	{
		timer = 0.0f;
		currentWord = m_symbol;
		ifSpeaking = true;
        AnimePlay();
        audioSource.PlayOneShot(audioClip);
    }

    void AnimePlay()
    {
        if(anime)
            anime.SetBool("ifTalking", true);
    }
}
