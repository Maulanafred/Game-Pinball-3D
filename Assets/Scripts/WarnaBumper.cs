using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarnaBumper : MonoBehaviour
{
    // Start is called before the first frame update

    public Color color;

    private Renderer renderer;
    void Start()
    {
        //Mengambil komponen renderer dari game object
        renderer = GetComponent<Renderer>();

        //Mengubah warna dari game object
        renderer.material.color = color;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
