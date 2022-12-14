using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubicalSounds : MonoBehaviour
{
    public AudioSource source;
    public AudioClip clip;

    int ticker = 0;
    void start() {
        source.PlayOneShot(clip);
    }
}
