using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LoadNewScene : MonoBehaviour {
    public string scene_1;
    public string scene_2;
    public string scene_3;
    public string scene_4;


    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.name == "Buzhi")
        {
            Debug.Log("Level2");
            SceneManager.LoadScene("scene_2");
        }
    }

    void Update()
    {
        SwitchScene();
    }

    private void SwitchScene()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1))
            SceneManager.LoadScene("scene_1");
        if (Input.GetKeyDown(KeyCode.Alpha2))
            SceneManager.LoadScene("scene_2");
        if (Input.GetKeyDown(KeyCode.Alpha3))
            SceneManager.LoadScene("scene_3");
        if (Input.GetKeyDown(KeyCode.Alpha4))
            SceneManager.LoadScene("scene_4");
    }
}
