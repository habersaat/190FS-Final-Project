using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IcebergShrink : MonoBehaviour
{
    public float scale = -0.001f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {   
        transform.localScale = transform.localScale + new Vector3(scale, 0, scale);
    }

}
