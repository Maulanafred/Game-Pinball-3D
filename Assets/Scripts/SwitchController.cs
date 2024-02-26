using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchController : MonoBehaviour
{ private enum SwitchState
  {
    Off,
    On,
    Blink
  }

  public Collider bola;
  public Material offMaterial;
  public Material onMaterial;

  public AudioManager audioManager;

  public ScoreManager scoreManager;
  
  public VFXManager vfxManager;

  public float score;

  private SwitchState state;
  private Renderer rend;

  private void Start()
  {
    rend = GetComponent<Renderer>();

    Set(false);

    StartCoroutine(BlinkTimerStart(5));
  }

  private void OnTriggerEnter(Collider other)
  {
    if (other == bola)
    {
      Toggle();

      //Menambahkan score ketika bola menyentuh switch
      scoreManager.AddScore(score);

    }
  }

  private void Set(bool active)
  {
    if (active == true)
    {
      state = SwitchState.On;
      rend.material = onMaterial;
      StopAllCoroutines();
  

    }
    else
    {
      state = SwitchState.Off;
      rend.material = offMaterial;
      StartCoroutine(BlinkTimerStart(5));

    }
  }

  private void Toggle()
  {
    if (state == SwitchState.On)
    {
      Set(false);
      audioManager.PlayCustomSFX(0);
      //Menampilkan efek partikel ketika switch dimatikan
      vfxManager.PlayVFX(transform.position);
      
      
    }
    else
    {
      Set(true);
      audioManager.PlayCustomSFX(1);
      vfxManager.PlayVFX(transform.position);
      
    }
  }

  private IEnumerator Blink(int times)
  {
    state = SwitchState.Blink;

    for (int i = 0; i < times; i++)
    {
      rend.material = onMaterial;
      yield return new WaitForSeconds(0.5f);
      rend.material = offMaterial;
      yield return new WaitForSeconds(0.5f);
    }

    state = SwitchState.Off;

    StartCoroutine(BlinkTimerStart(5));
  }

  private IEnumerator BlinkTimerStart(float time)
  {
    yield return new WaitForSeconds(time);
    StartCoroutine(Blink(2));
  }
}