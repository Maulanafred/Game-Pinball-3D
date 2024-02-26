using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerRamp : MonoBehaviour
{
    // Start is called before the first frame update
    public Collider bola;   
    public CameraController cameraController;

    public float length;
    // Start is called before the first frame update

    private void OnTriggerEnter(Collider other)
    {
        if (other == bola)
        {
            cameraController.FollowTarget(bola.transform, length);
        }

    }
    // Mengembalikan kamera ke posisi default
    private void OnTriggerExit(Collider other)
    {
        if (other == bola)
        {
            cameraController.GoBackToDefault();
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
