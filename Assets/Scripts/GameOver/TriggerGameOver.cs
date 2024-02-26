using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class TriggerGameOver : MonoBehaviour
{
    // Start is called before the first frame update

    public Collider bola;
    public GameObject gameOverPanel;

    public AudioManager audioManager;
    public GameOverUiScore gameOverUiScore;

    private void OnTriggerEnter(Collider other)
    {
        if (other == bola)
        {
            gameOverPanel.SetActive(true);
            gameOverUiScore.ShowGameOverScore();

            audioManager.StopBGM();
            audioManager.PlayCustomSFX(3);


            Time.timeScale = 0;

        
            
        }
    }
    void Start()
    {
        gameOverPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
