using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class GameOverUiScore : MonoBehaviour
{
    public TMP_Text scoreText; // Referensi ke objek teks di mana skor akan ditampilkan
    public ScoreManager scoreManager; // Referensi ke manajer skor

    // Method untuk menampilkan skor saat kalah
    public void ShowGameOverScore()
    {
        // Memperbarui teks dengan skor total dari score manager
        scoreText.text = "Game Over\nTotal Score: \n" + scoreManager.score.ToString();
    }
}
