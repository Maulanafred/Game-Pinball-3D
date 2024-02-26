using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreUIConroller : MonoBehaviour
{
    // Start is called before the first frame update


    //Menggunakan TextMeshPro untuk menampilkan score
    public TMP_Text scoreText;
    public ScoreManager scoreManager;

    void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        //Mengupdate score yang ditampilkan
        scoreText.text = scoreManager.score.ToString();
    }
}
