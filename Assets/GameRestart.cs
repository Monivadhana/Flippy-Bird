using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameRestart : MonoBehaviour
{   
    [SerializeField] GameObject player; 
   public void RestartGame()
   {
        Time.timeScale = 1f;
        player.GetComponent<ScoreUpdate>().currentScore = 0;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    
   }
}
