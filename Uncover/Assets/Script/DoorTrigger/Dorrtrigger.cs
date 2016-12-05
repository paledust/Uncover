using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Dorrtrigger : MonoBehaviour {
    public Transform endPoint;

    public GameObject player;
    public Image BackGround;
    public Color fadeColor;
    public float fadeSpeed;

    private bool ifActive;

    void Start()
    {
        ifActive = false;
        BackGround.enabled = false;
    }

    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject == player)
        {
            player.GetComponent<NavMeshAgent>().enabled = false;
            player.GetComponentInChildren<MovingCharacter>().enabled = false;
            ifActive = true;
        }
    }

    void MoveCharacter()
    {
        player.transform.position = Vector3.Lerp(player.transform.position, endPoint.position, 0.3f * Time.deltaTime);
    }

    void DarkScene()
    {
        if (!BackGround.enabled)
            BackGround.enabled = true;
        BackGround.color = Color.Lerp(BackGround.color, fadeColor, Time.deltaTime * fadeSpeed);

        if (BackGround.color.a >= 0.99)
        {
            BackGround.color = fadeColor;
        }
    }

    void Update()
    {
        if (ifActive)
        {
            Invoke("DarkScene", 5.0f*Time.deltaTime);
            MoveCharacter();
        }
    }
}
