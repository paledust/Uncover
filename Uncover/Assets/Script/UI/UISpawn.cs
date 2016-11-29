using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class UISpawn : MonoBehaviour {
	public GameObject PieUI;

	private GameObject spawnUI;
	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown ("Fire2")) {
			spawnUI = (GameObject)Instantiate (PieUI, Camera.main.ScreenToWorldPoint (Input.mousePosition)+Camera.main.transform.forward*10.0f, Quaternion.Euler (0, 0, 0));
		}

		if (Input.GetButton ("Fire2")) {
			spawnUI.GetComponent<CanvasCallOut_Screen> ().CallOn ();
		}

		if (Input.GetButtonUp ("Fire2")) {
			spawnUI.GetComponent<CanvasCallOut_Screen> ().startFade ();
			spawnUI = null;
		}
	}
}
