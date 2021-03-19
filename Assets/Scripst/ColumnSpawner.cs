using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColumnSpawner : MonoBehaviour
{
    public GameObject columnPrefab;
    public float minY;
    public float maxY;
    float timer;
    public float maxTime;

    // Start is called before the first frame update
    void Start()
    {
        SpawnColumn();
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer>=maxTime)
        {
            SpawnColumn();
            timer = 0;
        }
    }

    void SpawnColumn()
    {
        float randYPos = Random.Range(minY,maxY);
        GameObject newColumn = Instantiate(columnPrefab);
        newColumn.transform.position = new Vector2(
            transform.position.x, randYPos);
        
    }
}
