using UnityEngine;
using System.Collections;

public class OpenDoorAndFog : MonoBehaviour {
    public GameObject door;
    public ParticleSystem fog;
    public GameObject player;

    public void SetThemUp()
    {
        Invoke("setDoorUnlock", 1.0f * Time.deltaTime);
        fog.loop = false;
    }

    void setDoorUnlock()
    {
        door.SetActive(false);
        player.GetComponent<UnityEngine.AI.NavMeshAgent>().velocity = new Vector3(0, 0, 0);
    }

}
