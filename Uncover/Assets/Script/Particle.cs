using UnityEngine;
using System.Collections;

public class Particle : MonoBehaviour {
    public float Destroytime;
	// Use this for initialization
	void Start () {
        Destroy(gameObject, Destroytime);
	}
}
