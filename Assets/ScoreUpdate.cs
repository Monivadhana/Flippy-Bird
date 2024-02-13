using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreUpdate : MonoBehaviour
{
    public int currentScore; 
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Score"))
        {
            currentScore++;
        }
    }
}
