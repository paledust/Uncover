using UnityEngine;
using System.Collections;

public class CanvasFollow : MonoBehaviour {
	public Transform TargetTransform;

	private Vector3 bias;
	// Use this for initialization
	void Start () {
		TargetTransform = GameObject.FindGameObjectWithTag ("Player").transform;
		bias = transform.position - TargetTransform.position;
		transform.position = TargetTransform.position + bias;
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = TargetTransform.position + bias;
	}
}
