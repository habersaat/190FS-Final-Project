using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
 
public class WorldJump : MonoBehaviour
{
    public FadeScreen fadeScreen;

    public void GoToScene(int idx) {
        GoToSceneRoutine(idx);
    }

    IEnumerator GoToSceneRoutine(int idx) {
        Debug.Log("actovatedd");
        fadeScreen.FadeOut();
        yield return new WaitForSeconds(fadeScreen.duration);

        SceneManager.LoadScene(idx);
    }

    //Upon collision with another GameObject, this GameObject will reverse direction
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "VRHeadset") {
            int x = SceneManager.GetActiveScene().buildIndex;
            // GoToScene(x+1);
            SceneManager.LoadScene(x+1);
            Debug.Log("Working...");
        } 
    }

    public void jumpBack() {
        int x = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(x-1);
    }

}
