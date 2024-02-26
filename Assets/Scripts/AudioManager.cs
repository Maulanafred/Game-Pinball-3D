using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    // Start is called before the first frame update

    public AudioSource bgmaudioSource;

    public GameObject sfxaudioSource;

    public AudioSource[] sfx;


    private void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayBGM(){
        // Play background music
        bgmaudioSource.Play();
    }
    public void PlaySFX(Vector3 spawnPosition){
        // Play sound effect
        GameObject.Instantiate(sfxaudioSource, spawnPosition, Quaternion.identity);
    }

    public void PlayCustomSFX(int index)
    {
        // Memastikan indeks efek suara valid
        if (index >= 0 && index < sfx.Length)
        {
            // Mainkan efek suara pada indeks yang diberikan
            sfx[index].Play();
        }
        else
        {
            Debug.LogWarning("Invalid sound effect index!");
        }
    }

    public void StopBGM(){
        // Stop background music
        bgmaudioSource.Stop();
    }
}
