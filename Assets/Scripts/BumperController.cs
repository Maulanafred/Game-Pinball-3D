using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BumperController : MonoBehaviour
{
  public Collider bola;
  public float multiplier;
  public Color color;

  //Menambahkan AudioManager
  public AudioManager audioManager;

  public ScoreManager scoreManager;

  public float score;

  public VFXManager vfxManager;

  private Renderer renderer;
  private Animator animator;

  private void Start()
  {
    renderer = GetComponent<Renderer>();
    animator = GetComponent<Animator>();

    renderer.material.color = color;
  }

  private void OnCollisionEnter(Collision collision)
  {
    if (collision.collider == bola)
    {
      Rigidbody bolaRig = bola.GetComponent<Rigidbody>();
      bolaRig.velocity *= multiplier;

      //Melakukan animasi dan suara ketika bumper terkena bola
      animator.SetTrigger("Hit");
      audioManager.PlaySFX(collision.transform.position);

      //Menampilkan efek partikel ketika bumper terkena bola
      vfxManager.PlayVFX(collision.transform.position);

      //Menambahkan score ketika bumper terkena bola

      scoreManager.AddScore(score);
      
    }
  }
} 