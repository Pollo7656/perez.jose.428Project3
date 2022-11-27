using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrumStickSound : MonoBehaviour
{
  public AudioSource hit;
  void OnCollisionEnter (Collision collision){
    hit.Play();
  }
}