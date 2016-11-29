using UnityEngine;
using System.Collections;

public class MovingCharacter : MonoBehaviour {
	public float movingSpeed;
	public float angularSpeed;
	public float accelaration;
	public LayerMask disableLayer;

	private Ray clickRay;
	private RaycastHit hit;
	private NavMeshAgent navMesh;
	// Use this for initialization
	void Start () {
		navMesh = GetComponentInParent<NavMeshAgent> ();

		navMesh.speed = movingSpeed;
		navMesh.angularSpeed = angularSpeed;
		navMesh.acceleration = accelaration;

	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButton ("Fire1")) {
			Move ();
		}
		if (Input.GetButton ("Fire2")) {
			StopMove ();
		}
	}

	public void Move()
	{
		clickRay = Camera.main.ScreenPointToRay (Input.mousePosition);
		if (Physics.Raycast (clickRay, out hit)) {
			navMesh.SetDestination (hit.point);
		}
	}

	public void StopMove()
	{
		
	}
}
