using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class IcebergShrink : MonoBehaviour
{
    public float scale = -0.001f;
    private GameObject iceberg;
    // Start is called before the first frame update
    void Awake()
    {
        iceberg = GameObject.FindWithTag("Iceberg");
    }

    // Update is called once per frame
    void FixedUpdate()
    { 
        if(iceberg.transform.localScale.x > 0.5f) {
            transform.localScale = transform.localScale + new Vector3(scale, 0, scale);
        }
    }

}