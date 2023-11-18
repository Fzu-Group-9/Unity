using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RT : MonoBehaviour
{
    RedPlayer playerScript;
    private void Awake()
    {
        playerScript = GetComponentInParent<RedPlayer>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Ground")
        {
            playerScript.canJump = 2;
            playerScript.myAnim.SetBool("Jump", false);
            playerScript.canDash = true;
        }
    }
}
