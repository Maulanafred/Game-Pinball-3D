using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LauncherController : MonoBehaviour
{
	public Collider bola; // referensi ke bola
	public KeyCode input; // tombol input untuk aktivasi launch
	public float maxTimeHold; // waktu maksimal menahan tombol input
    public float maxForce; // besaran gaya dorong

    private Renderer renderer; // referensi ke komponen renderer
    private bool isHold; // status switch

    private Color originalColor; // warna asli dari game object
	
    private void Start()
    {
        isHold = false;
        renderer = GetComponent<Renderer>(); // mengambil komponen renderer
        originalColor = renderer.material.color; // menyimpan warna asli
    }
	
    // cek bola masuk ke dalam collider
	private void OnCollisionStay(Collision collision)
	{
		if (collision.collider == bola)
		{
			ReadInput(bola);
		}
	}
	
	// baca input
	private void ReadInput(Collider collider)
	{
		if (Input.GetKey(input) && !isHold)
        {
            StartCoroutine(StartHold(collider));

            //renderer.material.color = Color.blue; // Mengubah warna menjadi biru, misalnya
            
        }
        else
        {
            //mengubah warna menjadi aslinya
            //renderer.material.color = originalColor;
        }
	}

    private IEnumerator StartHold(Collider collider)
    {
    isHold = true;

    float force = 0.0f;
    float timeHold = 0.0f;

    while (Input.GetKey(input))
    {
        force = Mathf.Lerp(0, maxForce, timeHold/maxTimeHold);
        yield return new WaitForEndOfFrame();
        timeHold += Time.deltaTime;

        // mengubah warna menjadi biru berdasarkan waktu menahan tombol
        renderer.material.color = Color.Lerp(originalColor, Color.blue, timeHold/maxTimeHold);
        


    }

    

    collider.GetComponent<Rigidbody>().AddForce(Vector3.forward * force);
    isHold = false; renderer.material.color = originalColor;
    }
}