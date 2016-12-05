using UnityEngine;
using System.Collections;

public class MovingCharacter : MonoBehaviour {
	public float movingSpeed;
	public float angularSpeed;
	public float accelaration;
	public LayerMask disableLayer;
    public GameObject particleEffect;

	private Ray clickRay;
	private RaycastHit hit;
	private NavMeshAgent navMesh;
    private Animator anime;
	// Use this for initialization
	void Start () {
		navMesh = GetComponentInParent<NavMeshAgent> ();

		navMesh.speed = movingSpeed;
		navMesh.angularSpeed = angularSpeed;
		navMesh.acceleration = accelaration;

        anime = transform.parent.GetComponentInChildren<Animator>();
    }
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButton ("Fire1")) {
			Move ();
		}

        Animation();
    }

	public void Move()
	{
		clickRay = Camera.main.ScreenPointToRay (Input.mousePosition);
		if (Physics.Raycast (clickRay, out hit)) {
			navMesh.SetDestination (hit.point);
            CreateParticle(hit.point);
        }
	}

    void Animation()
    {
        anime.SetFloat("speed", navMesh.velocity.magnitude);
    }

    void CreateParticle(Vector3 position)
    {
        Instantiate(particleEffect, position, Quaternion.Euler(0,0,0));
    }

}
