using UnityEngine;
using System.Collections;

public class EarDetection : MonoBehaviour {
	public float detectionRange;
	public bool ifHeard;

	private GameObject parent;
	private GameObject player;
	// Use this for initialization
	void Start () {
		GetComponent<SphereCollider> ().radius = detectionRange;
		parent = transform.parent.gameObject;
		player = GameObject.FindGameObjectWithTag ("Player");
		ifHeard = false;
	}

	void Update()
	{
		if (ifHeard) {
			
		}
	}
	
	// Update is called once per frame
	void OnTriggerStay(Collider collider)
	{
		if (collider.gameObject == player) {
			ifHeard = player.GetComponentInChildren<Speak> ().ifSpeaking;
		}
	}
}
