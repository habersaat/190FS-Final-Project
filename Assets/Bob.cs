using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Bob : MonoBehaviour
{
    
    private GameObject[] items;
    private Vector3[] directions;
    float speed = 0.125f;
    // Start is called before the first frame update
    void Start()
    {

        float x1 = -100.0f;
        float y1 = -100.0f;
        float x2 = 100.0f;
        float y2 = 100.0f;

        directions = new Vector3[1254];

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

        for(int i = 0; i < 1254; i++) {
            directions[i] = new Vector3(0, speed, 0);
        }
    }

    // Update is called once per frame
    int ticker = 0;
    Vector3 Direction = Vector3.up;
    
    
    void Update()
    {
        int tracker = 0;
        ticker++;
        if(ticker % 240 == 0) Direction *= -1;
        items = GameObject.FindGameObjectsWithTag("bob");
        foreach(GameObject r in items)
        {  
            if(r.transform.position.y > 0.25) {
                directions[tracker] = new Vector3(0, -speed, 0);;
            } else if (r.transform.position.y < -0.25) {
                directions[tracker] = new Vector3(0, speed, 0);;
            }
            float randomness = Random.Range(1, 4);
            r.transform.Translate((Vector3) directions[tracker] * randomness * Time.deltaTime, Space.World);
            tracker++;
        }
    }

    void SpawnObject(GameObject objectToSpawn, float x1, float y1, float x2, float y2)
    {
        float x = Random.Range(x1, x2);
        float y = Random.Range(-0.5f, -0.25f);
        float z = Random.Range(y1, y2);
        Vector2 spawnPoint = new Vector2(x, y);
        Instantiate(objectToSpawn, new Vector3(x, y, z), Random.rotation);
}
}
