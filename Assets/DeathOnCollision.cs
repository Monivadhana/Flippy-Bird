using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using Unity.VisualScripting;
using UnityEngine;

public class DeathOnCollision : MonoBehaviour
{
    [SerializeField] GameObject Restart;


   private void OnCollisionEnter2D(Collision2D collision)
   {
        Death();
   }

   private void Death()
   {
        Time.timeScale = 0f;
        Restart.SetActive(true);
   }
}
