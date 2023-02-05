using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAudio : MonoBehaviour
{
    //public AudioClip myClip;
    public AudioSource audioSource;

    //void OnTriggerEnter2D(Collider2D collision)
    //{
    //    if (collision.tag == "Player" && !audioSource.isPlaying)
    //    {
    //        audioSource.Play();
    //        //Debug.Log("collide");
    //        //audioSource = GetComponent<AudioSource>();
    //        //audioSource.PlayOneShot(audioSource.clip);
    //        ////audioSource.Play();
    //    }
    //}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player" && !audioSource.isPlaying)
        {
            audioSource.Play();
            Debug.Log("collide");
            //audioSource = GetComponent<AudioSource>();
            //audioSource.PlayOneShot(audioSource.clip);
            ////audioSource.Play();
        }
    }
}
