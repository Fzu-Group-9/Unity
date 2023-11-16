using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameMmanager : MonoBehaviour
{
    public Button pause_button;
    public Button resume_button;

    public void PauseGame()
    {
        Time.timeScale = 0;
    }
    public void ResumeGame()
    {
        Time.timeScale = 1;
    }
    private void Start()
    {
        pause_button.onClick.AddListener(PauseGame);

        resume_button.onClick.AddListener(ResumeGame);
    }
}
