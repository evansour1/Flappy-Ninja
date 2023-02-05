using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColumnSpawn : MonoBehaviour {
    public float spawnRate = 4f;
    public int columnSpawnSize = 5;
    public float columnYMin = -6.3f;
    public float columnYMax = -2.3f;
    private float lastSpawn;
    private float spawnX = 12f;
    private int currectColumn = 0;
    public GameObject columnsPrefabs;
    private GameObject[] columns;
    private Vector2 objectSpawnPosition = new Vector2(-15, -25f);
    public GameObject columnDown;




	// Use this for initialization
	void Start () {
        columns = new GameObject[columnSpawnSize];
        for(int i = 0; i < columnSpawnSize; i++)
        {
            columns[i] = Instantiate(columnsPrefabs, objectSpawnPosition, Quaternion.identity);

        } 
	}
	
	// Update is called once per frame
	void Update () {
        lastSpawn += Time.deltaTime;

        if (lastSpawn >= spawnRate)
        {
            lastSpawn = 0;
            float spawnYPos = Random.Range(columnYMin, columnYMax);
            columns[currectColumn].transform.position = new Vector2(spawnX, spawnYPos);
            currectColumn++;
            if(currectColumn >= columnSpawnSize) { currectColumn = 0; }


        }
        
	}
    

    public void Destr()
    {
        for (int i = 0; i < columnSpawnSize; i++)
        {
            Destroy(columns[i]);

        }
    }

    public void Instantiate()
    {
        columns = new GameObject[columnSpawnSize];
        for (int i = 0; i < columnSpawnSize; i++)
        {
            columns[i] = Instantiate(columnsPrefabs, objectSpawnPosition, Quaternion.identity);

        }
    }

    
}
