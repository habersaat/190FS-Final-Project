using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class PilingWork : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Spawner());
    }

    IEnumerator Spawner() {
        System.Random rnd = new System.Random();
        yield return new WaitForSeconds(rnd.Next(0, 8));
        float x1 = -8f;
        float y1 = 11f;
        float x2 = -5.5f;
        float y2 = 12.5f;

        GameObject papers = GameObject.Find("PaperStack");
        for (int i = 0; i < 1; i++) {
            SpawnObject(papers, x1, y1, x2, y2);
        }
    }


    void SpawnObject(GameObject objectToSpawn, float x1, float y1, float x2, float y2)
    {
        Debug.Log("Object Spawning...");
        float x = UnityEngine.Random.Range(x1, x2);
        float y = UnityEngine.Random.Range(2f, 3f);
        float z = UnityEngine.Random.Range(y1, y2);
        Instantiate(objectToSpawn, new Vector3(x, y, z), UnityEngine.Random.rotation);
}
}
