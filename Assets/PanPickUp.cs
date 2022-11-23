using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanPickUp : MonoBehaviour
{
  public AudioSource clang_sound;

  void OnCollisionEnter (Collision collision){
      clang_sound.Play();
  }

}
