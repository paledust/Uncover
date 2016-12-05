using UnityEngine;
using System.Collections;

public class OpenDoorAndFog : MonoBehaviour {
    public GameObject door;
    public GameObject fog;

    public void SetThemUp()
    {
        door.SetActive(false);
        fog.GetComponent<ParticleSystem>().loop = false;
    }

}
