using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAudio : MonoBehaviour
{
    //public AudioClip myClip;
    private AudioSource audioSource;
    bool audioplayed = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player" && audioplayed == false)
        {
            audioSource = this.GetComponent<AudioSource>();
            audioSource.Play();
            audioplayed = true;
        }
       
    }
}
