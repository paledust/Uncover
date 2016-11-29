using UnityEngine;
using System.Collections;

public class MovingCharacter_KeyBoard : MonoBehaviour {
	public float moveSpeed;

	private Rigidbody playerRigid;
	// Use this for initialization
	void Start () {
		playerRigid = GetComponentInParent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		playerRigid.velocity = Vector3.forward * moveSpeed * Input.GetAxis ("Vertical") +
			Vector3.right * moveSpeed *  Input.GetAxis ("Horizontal");
	}
}
