using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
 
public class WorldJump : MonoBehaviour
{
    //Upon collision with another GameObject, this GameObject will reverse direction
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "VRHeadset") {
            int x = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(x+1);
            Debug.Log("Working...");
        } 
    }

}
