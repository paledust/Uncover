using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class buttonTest : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler {
	public bool ifHighlight;
	public string symbolMeaning;

	private Button button;
	private GameObject player;
	void Start()
	{
		button = GetComponent<Button> ();
		ifHighlight = false;
		player = GameObject.FindGameObjectWithTag ("Player");
	}

	void Update()
	{
		if (ifHighlight) {
			if (Input.GetButtonUp ("Fire2")) {
				CallButtonName ();
			}
		}
	}

	//When mouse getinto
	public void OnPointerEnter(PointerEventData eventData)
	{
		ifHighlight = true;
	}

	public void OnPointerExit(PointerEventData eventData)
	{
		ifHighlight = false;
	}

	void CallButtonName()
	{
		player.GetComponentInChildren<Speak>().SendMessage ("saySymbol", symbolMeaning);
	}

}
