using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SendBack : MonoBehaviour
{

    public FadeScreen fadeScreen;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Starting 1");
        StartCoroutine(GoToSceneRoutine());
    }

    IEnumerator GoToSceneRoutine() {
        Debug.Log("Starting 2");
        yield return new WaitForSeconds(22.5f);
        Debug.Log("actovatedd");
        //fadeScreen.FadeOut();
        //yield return new WaitForSeconds(fadeScreen.duration);

        SceneManager.LoadScene(5);
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
}
