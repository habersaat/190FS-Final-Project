using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubicalSounds : MonoBehaviour
{
    public AudioSource source;
    public  AudioSource source2;
    public AudioClip clip1;
    public AudioClip clip2;
    public AudioClip clip3;

    int ticker = 0;
    void start() {
        source.PlayOneShot(clip1);
    }
    // Update is called once per frame
    void Update()
    {
        ticker++;
        if(ticker == 1500) {
            Debug.Log("Played 2");
            source.PlayOneShot(clip2);
        }
        if(ticker == 3000) {
            Debug.Log("Played 3");
            source.PlayOneShot(clip3);
        }
    }
}
