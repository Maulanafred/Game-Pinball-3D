using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VFXManager : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject vfxSource;
    private void Start()
    {       
    
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayVFX(Vector3 spawnPosition){
        // Play visual effect
        GameObject.Instantiate(vfxSource, spawnPosition, Quaternion.identity);




    }
}
