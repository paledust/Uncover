using UnityEngine;
using System.Collections;

public class JumpAnimation : MonoBehaviour {
    public AnimationCurve curve;
    public float JumpHeight;

    private bool ifJump;
    // Use this for initialization
    void Start()
    {
        ifJump = false;
    }

    void Update()
    {
        if (ifJump)
        {
            Debug.Log("Jump");
            transform.localPosition +=  -Vector3.up * Time.deltaTime* Time.deltaTime ;
        }
    }

    // Jumping Animation
    public void Jump()
    {
        ifJump = true;
    }

    public void StopJumping()
    {
        ifJump = false;
    }
}
