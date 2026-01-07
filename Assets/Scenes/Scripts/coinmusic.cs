using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinmusic : MonoBehaviour
{
    public AudioSource musicsource;
    public AudioClip musicclip;

    // Start is called before the first frame update
    void Start()
    {
        musicsource.clip = musicclip;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        musicsource.Play();
    }
}
