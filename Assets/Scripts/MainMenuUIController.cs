using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuUIController : MonoBehaviour
{
    // Start is called before the first frame update

    public Button playButton;
    public Button exitButton;
    private void Start()

    {
        playButton.onClick.AddListener(PlayGame);
        exitButton.onClick.AddListener(ExitGame);
    }

    // Update is called once per frame

    public void PlayGame()
    {
        SceneManager.LoadScene("Pinball");
        // Membuat game berjalan normal
        Time.timeScale = 1;
    }

    private void ExitGame()
    {
        Application.Quit();
    }
    void Update()
    {
        
    }
}
