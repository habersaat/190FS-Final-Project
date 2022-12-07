using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class JumpBack : MonoBehaviour
{
    public void jumpBack() {
        Debug.Log("Backl baby");
        int x = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(x-1);
    }
}
