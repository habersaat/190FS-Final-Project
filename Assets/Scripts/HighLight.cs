using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighLight : MonoBehaviour
{
    Renderer r;

    public Color emissiveColor;

    // Start is called before the first frame update
    void Start()
    {
        r=GetComponentInChildren<Renderer>();
        if(r==null){
            Debug.LogError("couldn't find a renderer component among the children!");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Highlight()
    {
        Debug.Log("highlight");
        r.material.EnableKeyword("_EMISSION"); 
        r.material.SetColor("_EmissionColor",emissiveColor);
    }

    public void NoHighLight()
    {
        Debug.Log("no highlight");
        r.material.SetColor("_EmissionColor",new Color(0.0f,0.0f,0.0f));
    }
}
