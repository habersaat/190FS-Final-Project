using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogEvent : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void LogPositive()
    {
        Debug.Log("ObjectL " + this.gameObject.name + " is positive!");
    }
    public void LogNegative()
    {
        Debug.Log("ObjectL " + this.gameObject.name + " is negative!");
    }
}
