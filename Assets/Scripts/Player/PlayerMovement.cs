using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public partial class PlayerMovement : MonoBehaviour
{
    public CharacterController2D Controller;
    public Animator Animator;
    private const float MoveSpeed = 0.5f;
    private bool jump = false;
    private bool crouch = false;
    private float horizontalMove = 0f;
    void Start()
    {

    }

    private void Update()
    {


        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
                Animator.SetBool("IsJumping", true);
        }
        if (Input.GetButtonDown("Crouch"))
        {
            crouch = true;
        } 
        else if (Input.GetButtonUp("Crouch"))
        {
            crouch = false;
        }

    }

    public bool TestJump = false;
    public int LandCount = 0;
     public void OnLandEvent ()
    {
        Animator.SetBool("IsJumping", false );
    }

     public void OnCrouchEvent(bool IsCrouching)
     {
        Animator.SetBool("IsCrouching", IsCrouching );
     }
     void FixedUpdate()
    {
        
        Animator.SetFloat("Speed", Mathf.Abs(horizontalMove));
        horizontalMove = Input.GetAxisRaw("Horizontal") * MoveSpeed;
        Controller.Move(horizontalMove, crouch, jump);
        jump = false;
    }
}
