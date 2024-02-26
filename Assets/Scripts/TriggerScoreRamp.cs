using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerScoreRamp : MonoBehaviour
{
    // Start is called before the first frame update

    public Collider bola;

    public AudioManager audioManager;
    public ScoreManager scoreManager;
    public float score;

    private void OnTriggerEnter(Collider other)
    {
        if (other == bola)
        {
            scoreManager.AddScore(score);
            audioManager.PlayCustomSFX(2);
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
