using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorToHill : MonoBehaviour
{
    public GameObject menu;
    public static bool canOpen;
    void Start()
    {
        canOpen = false;
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if ((collision.gameObject.CompareTag("Player") || collision.gameObject.CompareTag("Player1")) && canOpen)
        {
            Time.timeScale=0;
            menu.SetActive(true);
        }
    }
}
