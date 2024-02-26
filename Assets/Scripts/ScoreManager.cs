using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    // Start is called before the first frame update

    public float score;


    public void AddScore(float scoreToAdd)
    {
        score += scoreToAdd;
    }

    public void ResetScore()
    {
        score = 0;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
