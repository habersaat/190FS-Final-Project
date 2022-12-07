using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotentialGlitch : MonoBehaviour
{
    private GameObject[] items;
    // Start is called before the first frame update
    void Start()
    {

        float x1 = -100.0f;
        float y1 = -100.0f;
        float x2 = 100.0f;
        float y2 = 100.0f;


        GameObject bottle = GameObject.Find("L2-bottle");
        bottle.tag="bob";
        for (int i = 0; i < 500; i++) {
            SpawnObject(bottle, x1, y1, x2, y2);

        }

        GameObject plasticrings = GameObject.Find("L2-plastic-rings");
        plasticrings.tag="bob";
        for (int i = 0; i < 500; i++) {
            SpawnObject(plasticrings, x1, y1, x2, y2);
        }

        GameObject tire = GameObject.Find("L2-tire 1");
        tire.tag="bob";
        for (int i = 0; i < 125; i++) {
            SpawnObject(tire, x1, y1, x2, y2);
        }

        GameObject trafficcone = GameObject.Find("L2-traffic-cone");
        trafficcone.tag="bob";
        for (int i = 0; i < 125; i++) {
            SpawnObject(trafficcone, x1, y1, x2, y2);
        }
    }

    // Update is called once per frame
    void Update()
    {
        float speed = 0.5f;
        Vector3 Direction = Vector3.up;
        items = GameObject.FindGameObjectsWithTag("bob");
        foreach(GameObject r in items)
        {
            if (Random.Range(0, 5) == 0) {
                Direction = Vector3.up;
            }
            else if (Random.Range(0, 5) == 1) {
                Direction = Vector3.down;
            }
            else if (Random.Range(0, 5) == 2) {
                Direction = Vector3.left;
            }
            else if (Random.Range(0, 5) == 3) {
                Direction = Vector3.right;
            }
            else if (Random.Range(0, 5) == 4) {
                Direction = Vector3.forward;
            }
            else if (Random.Range(0, 5) == 5) {
                Direction = Vector3.forward * -1;
            }
            r.transform.Translate(Direction * speed * Time.deltaTime);
        }

    }

    void SpawnObject(GameObject objectToSpawn, float x1, float y1, float x2, float y2)
    {
        float x = Random.Range(x1, x2);
        float y = 0.25f;
        float z = Random.Range(y1, y2);
        Vector2 spawnPoint = new Vector2(x, y);
        Instantiate(objectToSpawn, new Vector3(x, y, z), Random.rotation);
}
}
