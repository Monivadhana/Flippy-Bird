using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public int x;
      Jumper jumper;
      [SerializeField] KeyCode jumpButton;

      private void Start()
      {
        jumper = GetComponent<Jumper>();
    
      }

      private void Update()
      {
        if(Input.GetKeyDown(jumpButton))
        {
            jumper.Jump();
        }
        
    }
}
