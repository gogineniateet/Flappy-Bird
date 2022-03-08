using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeftScript : MonoBehaviour
{
    public float speed;
    ScoreManager scoreManager;
    BirdMovement birdMovement;

    public void Start()
    {
        birdMovement = GameObject.Find("Player").GetComponent<BirdMovement>();

        if (birdMovement.isGameOver == false)
        {
            scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();

        }
    }
    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector2(transform.position.x  - speed * Time.deltaTime, transform.position.y);
        if (transform.position.x < -4f)
        {
            Destroy(gameObject);         
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        birdMovement = GameObject.Find("Player").GetComponent<BirdMovement>();

        if (collision.CompareTag("Player"))
        {
            scoreManager.ScoreUpdate(10);
        }
    }
}
