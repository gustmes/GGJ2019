using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodSpawn : MonoBehaviour {

    [SerializeField] Food foodPrefab;
    [SerializeField] float minFoodSpawnRate;
    [SerializeField, Range(0f, 100f)] float maxFoodSpawnRate;

    [SerializeField] BoxCollider2D levelBox;

    float timeToSpawn;
    float timer = 0f;

    private void Start()
    {
        timeToSpawn = (minFoodSpawnRate <= 0f) ? maxFoodSpawnRate : Random.Range(minFoodSpawnRate, maxFoodSpawnRate);
    }

    private void Update()
    {
        timer += Time.deltaTime;
        if (timer >= timeToSpawn)
        {
            SpawnFood();
            timer = 0f;

            timeToSpawn = (minFoodSpawnRate <= 0f) ? maxFoodSpawnRate : Random.Range(minFoodSpawnRate, maxFoodSpawnRate);
        }
    }

    void SpawnFood()
    {
        Debug.Log("Spawn food");
    }
}
