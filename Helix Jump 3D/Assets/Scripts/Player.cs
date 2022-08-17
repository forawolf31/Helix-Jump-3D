using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody playerRB;
    public float bounceForce= 6;

    private AudioManager audioManager;

    private void Start()
    {
        audioManager = FindObjectOfType<AudioManager>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        FindObjectOfType<AudioManager>().Play("bounce");
        playerRB.velocity = new Vector3(playerRB.velocity.x, bounceForce, playerRB.velocity.z);
        string materialName = collision.transform.GetComponent<MeshRenderer>().material.name;

        if (materialName == "Safe (Instance)")
        {
            //The ball hits the safe 
        }else if(materialName == "Unsafe (Instance)")
        {
            //The ball hits the unsafe area
            audioManager.Play("gameover");
            GameManager.gameOver = true;
        }else if(materialName == "LastRing (Instance)" && !GameManager.levelCompleted)
        {
            //We Completed the Level
            audioManager.Play("win");
            GameManager.levelCompleted = true;
        }
        


}





}
