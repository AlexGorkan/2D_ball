using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallsSpawner : MonoBehaviour
{
    [SerializeField] private Vector2 spawnPosition;
    [SerializeField] private Vector2 xSpawnBounds;
    [SerializeField] private Vector2 ySpawnBounds;
    [SerializeField] private GameObject ballPrefab;
    [SerializeField] private int ballsAmount;



    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < ballsAmount; i++)
        {
            float xRandomPosition = Random.Range(xSpawnBounds.x, xSpawnBounds.y); // diapazon 1-6 daet randomnoe chislo
            float yRandomPosition = Random.Range(ySpawnBounds.x, ySpawnBounds.y);
            Vector2 randomSpawnPosition = new Vector2(xRandomPosition, yRandomPosition); //sozdaetsa novaia coordinata 
            Instantiate(ballPrefab, randomSpawnPosition, ballPrefab.transform.rotation); //spawn s uslovijami v skobkah
                                                                                         
        }
    }
      
}
