using UnityEngine;
using System.Collections;

public class VoiceRadar : MonoBehaviour {
	public float radarRange = 1;

	private Speak speaker;
	private bool ifSend;
	// Use this for initialization
	void Start () {
		GetComponent<SphereCollider> ().radius = radarRange;
		speaker = transform.parent.GetComponentInChildren<Speak> ();
		ifSend = true;
	}

	void Update()
	{
		if (!speaker.ifSpeaking) {
			ifSend = true;
		}
	}

	void OnTriggerStay(Collider collider)
	{
		if (collider.tag == "Creature" && speaker.ifSpeaking && ifSend) {
			ifSend = false;
			collider.GetComponentInChildren<VoiceReaction> ().reaction (speaker.currentWord);
		}
	}
}
