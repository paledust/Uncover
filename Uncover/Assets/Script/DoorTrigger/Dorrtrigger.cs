using UnityEngine;
using System.Collections;

public class Dorrtrigger : MonoBehaviour {
    public Transform startPoint;
    public Transform endPoint;

    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.name == "Bunzu")
        {
            collider.gameObject.GetComponent<NavMeshAgent>().enabled = false;
            collider.gameObject.GetComponentInChildren<MovingCharacter>().enabled = false;
        }
    }

    void MoveCharacter()
    {

    }
}
