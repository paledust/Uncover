using UnityEngine;
using System.Collections;

public class CameraLook : MonoBehaviour {
	public GameObject target;
	public bool isActivate;

	private Vector3 bias;
	// Use this for initialization
	void Start () {
		bias = transform.position - target.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		if (isActivate) {
			CameraControl ();
		}
	}

	private void CameraControl()
	{
		transform.position = new Vector3 (target.transform.position.x + bias.x, 
			target.transform.position.y + bias.y, 
			target.transform.position.z + bias.z);
	}
}
