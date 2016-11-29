using UnityEngine;
using System.Collections;

public class VoiceRadarDetection : MonoBehaviour {
	private Speak m_speak;
	// Use this for initialization
	void Start () {
		m_speak = transform.parent.GetComponentInChildren<Speak> ();
	}
	
	// Update is called once per frame
	void OnTriggerEnter(Collider collider)
	{
		
	}
}
