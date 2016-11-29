using UnityEngine;
using System.Collections;

public class CanvasCall_FollowCamera : MonoBehaviour {
	private Vector3 bias;
	// Use this for initialization
	void Start () {
		bias = transform.position - Camera.main.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = Camera.main.transform.position + bias;
	}
}
