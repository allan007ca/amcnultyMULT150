using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatSpawner : MonoBehaviour
{
    public GameObject donutPrefab;

    public float spawnCycle = 1.5f;

    GameManager manager;
    float elapsedTime;
    bool spawnDonut = true;

    void Start()
    {
        manager = GetComponent<GameManager>();
    }

    void Update()
    {
        elapsedTime += Time.deltaTime;

        if (elapsedTime > spawnCycle)
        {
            GameObject temp;

            if (spawnDonut)
                temp = Instantiate(donutPrefab) as GameObject;
            else
                temp = Instantiate(donutPrefab) as GameObject;   

            Vector3 position = temp.transform.position;
            position.x = Random.Range(-3f, 3f);
            temp.transform.position = position;

            elapsedTime = 0;
            spawnDonut = !spawnDonut;  
        }
    }
}