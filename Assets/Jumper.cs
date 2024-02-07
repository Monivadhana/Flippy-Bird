using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumper : MonoBehaviour
{
        Rigidbody2D rb2D;
        [SerializeField] float jumpForce;
        Animator animator;
        bool isJumping;

        const string jumpParmeter = "isJumping";
        
        private void Start()
        {
            rb2D = GetComponent<Rigidbody2D>();
            animator = GetComponentInChildren<Animator>();
        }

        private void Update()
        {

            if(isJumping)
            {
                if(rb2D.velocity.y <= 0f)
                {
                    isJumping = false;
                    animator.SetBool(jumpParmeter, isJumping);
                }
            }
        }
        
        public void Jump()
        {
            
            rb2D.velocity = Vector2.up * jumpForce;
            isJumping = true; 
            animator.SetBool("isJumping", isJumping);
        }
}
