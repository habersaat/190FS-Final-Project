using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class bobBetter : MonoBehaviour
{
    
    private GameObject[] items;
    private double[] positions;
    private Color[] chipColors;
    // Start is called before the first frame update
    void Start()
    {

        float x1 = -100.0f;
        float y1 = -100.0f;
        float x2 = 100.0f;
        float y2 = 100.0f;
        // chipColors = {new Color(1,0,0,0); new Color(0,1,0,0); new Color(0,0,1,0)};
        chipColors = new Color[3];
        chipColors[0] = new Color(1,0,0,0);
        chipColors[1] = new Color(1,1,0,0);
        chipColors[2] = new Color(0,0,1,0);
        positions = new double[1506];

        GameObject bottle = GameObject.Find("L2-bottle");
        for (int i = 0; i < 500; i++) {
            SpawnObject(bottle, x1, y1, x2, y2, false);
        }
        GameObject plasticrings = GameObject.Find("L2-plastic-rings");
        for (int i = 0; i < 500; i++) {
            SpawnObject(plasticrings, x1, y1, x2, y2, false);  
        }

        GameObject tire = GameObject.Find("L2-tire 1");
        for (int i = 0; i < 125; i++) {
            SpawnObject(tire, x1, y1, x2, y2, false);
        }

        GameObject trafficcone = GameObject.Find("L2-traffic-cone");
        for (int i = 0; i < 125; i++) {
            SpawnObject(trafficcone, x1, y1, x2, y2, false);
        }

        GameObject plasticBag = GameObject.Find("L2-plastic bag");
        for (int i = 0; i < 125; i++) {
            SpawnObject(plasticBag, x1, y1, x2, y2, false);
        }

        GameObject chips = GameObject.Find("L2-chips");
        for (int i = 0; i < 125; i++) {
            SpawnObject(chips, x1, y1, x2, y2, true);
        }

        for(int i = 0; i < 1506; i++) {
            positions[i] = Random.Range(0,180);
        }
    }

    
    // Update is called once per frame
    void Update()
    {
        int tracker = 0;
        items = GameObject.FindGameObjectsWithTag("bob");
        foreach(GameObject r in items)
        {
            positions[tracker] += 1;  
            r.transform.position = new Vector3(r.transform.position.x, (float) positionFunction(positions[tracker]), r.transform.position.z);
            tracker++;
        }
    }


    void SpawnObject(GameObject objectToSpawn, float x1, float y1, float x2, float y2, bool chips)
    {
        float x = Random.Range(x1, x2);
        float y = Random.Range(-0.5f, -0.25f);
        float z = Random.Range(y1, y2);
        Vector2 spawnPoint = new Vector2(x, y);
        if(chips) {
            int c = (int) Random.Range((float) 0, (float) 2.99);
            Debug.Log(c);
            GameObject obj = Instantiate(objectToSpawn, new Vector3(x, y, z), Random.rotation);
            obj.GetComponent<Renderer>().material.color = chipColors[c];
        }
        else Instantiate(objectToSpawn, new Vector3(x, y, z), Random.rotation);
    }

    double positionFunction(double ticker) {
        return 0.125 * Mathf.Sin((float)(ticker / 60.0)) - 0.125; 
    }
}
