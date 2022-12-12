using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IcebergCrack : MonoBehaviour
{
    public int waitTime;
    public Vector3 direction;
    public AudioSource source;
    public AudioClip clip;

    int ticker = 0;
    // Update is called once per frame
    void Update()
    {
        ticker++;
        if(ticker == waitTime) source.PlayOneShot(clip);
        if(ticker > waitTime) transform.position += direction;
    }

}
