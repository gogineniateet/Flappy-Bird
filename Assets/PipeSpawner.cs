using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public GameObject pipePrefab;
    public float minY, maxY;
    public float time;
    BirdMovement birdMovement;

    // Start is called before the first frame update
    void Start()
    {
        birdMovement = GameObject.Find("Player").GetComponent<BirdMovement>();
        InvokeRepeating("PipeSpawnner", 2f, 2f);                 
    }

    private void PipeSpawnner()
    {
        if (birdMovement.isGameOver == false)
        {
            GameObject newPipe = Instantiate(pipePrefab);
            newPipe.transform.position = new Vector2(transform.position.x, UnityEngine.Random.Range(minY, maxY));
        }               
    }
}
