using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ring : MonoBehaviour
{
    private Transform player;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    
    void Update()
    {
        if (transform.position.y > player.position.y)
        {
            FindObjectOfType<AudioManager>().Play("whoosh");
            GameManager.numberOfPassedRings++;
            GameManager.score++;
            Destroy(gameObject);
        }
    }
}
