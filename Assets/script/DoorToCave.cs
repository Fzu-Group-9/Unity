using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorToCave : MonoBehaviour
{
    public AudioClip[] myAudioClip;
    AudioSource myAudioSource;
    public GameObject menu;
    // Start is called before the first frame update
    public static bool canOpen;
    void Start()
    {
        canOpen = false;
        myAudioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if ((collision.gameObject.CompareTag("Player") || collision.gameObject.CompareTag("Player1")) && canOpen)
        {
            myAudioSource.PlayOneShot(myAudioClip[0]);
            Time.timeScale=0;
            menu.SetActive(true);
        }
    }
}
