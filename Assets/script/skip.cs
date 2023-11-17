using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class skip : MonoBehaviour
{
    public GameObject menu;
    public AudioClip [] myAudioClip;
    AudioSource myAudioSource;
    // public GameObject sceen;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void Awake()
    {
         myAudioSource = GetComponent<AudioSource>();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    public void Jump_forest()
    {
        myAudioSource.PlayOneShot(myAudioClip[0]);
        SceneManager.LoadScene(0);
        Time.timeScale=1;
    }
    public void Jump_cave()
    {
        myAudioSource.PlayOneShot(myAudioClip[0]);
        SceneManager.LoadScene(1);
        Time.timeScale=1;
    }
    public void jump_hill()
    {
        myAudioSource.PlayOneShot(myAudioClip[0]);
        SceneManager.LoadScene(2);
        Time.timeScale=1;
    }
    public void Jump_running()
    {
        myAudioSource.PlayOneShot(myAudioClip[0]);
        SceneManager.LoadScene(3);
        Time.timeScale=1;
    }
    public void Jump_levelSelect()
    {
        myAudioSource.PlayOneShot(myAudioClip[0]);
        SceneManager.LoadScene(4);
    }
    public void Jump_title()
    {
        myAudioSource.PlayOneShot(myAudioClip[0]);
        SceneManager.LoadScene(5);
    }
    public void Jump_pause()
    {
        myAudioSource.PlayOneShot(myAudioClip[0]);
        SceneManager.LoadScene(6);
    }

    public void level_pause()
    {
        myAudioSource.PlayOneShot(myAudioClip[0]);
        Time.timeScale=0;
        menu.SetActive(true);
    }

    public void level_return()
    {
        myAudioSource.PlayOneShot(myAudioClip[0]);
        menu.SetActive(false);
        Time.timeScale=1;
    }
    public void Jump_maoxian()
    {
        myAudioSource.PlayOneShot(myAudioClip[0]);
        SceneManager.LoadScene(7);
        
    }
    public void Jump_paoku()
    {
        myAudioSource.PlayOneShot(myAudioClip[0]);
        SceneManager.LoadScene(8);
        
    }

}
