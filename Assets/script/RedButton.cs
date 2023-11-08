using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedButton : MonoBehaviour
{
    PlayerRed playerScript;
    private void Awake()
    {
        playerScript = GetComponentInParent<PlayerRed>();
    }
    private void OnTriggerEnter2D(Collider2D collision)//��ⴥ���ذ壬����Ծ��Э��
    {
        if (collision.tag == "Ground")
        {
            playerScript.canJump = true;
            playerScript.myAnim.SetBool("Jump", false);
        }
    }
}
