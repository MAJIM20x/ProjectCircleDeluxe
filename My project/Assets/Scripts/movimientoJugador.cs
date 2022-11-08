using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimientoJugador : MonoBehaviour
{
    [SerializeField]private float speed = 3f;
    [SerializeField]private bool isPlauer1;
    [SerializeField]private bool isPlayer2;
    [SerializeField]private bool isPlayer3;
    [SerializeField]private bool isPlayer4;

    private Rigidbody2D playerRb;
    private Vector2 moveInput;
    private Animator playerAnimator;
    
    
    void Start()
    {
        playerRb = GetComponent<Rigidbody2D>();
        playerAnimator = GetComponent<Animator>();
    }

    
    void Update()
    {   

        if(isPlauer1){

            float moveX = Input.GetAxisRaw("Horizontal");
            float moveY = Input.GetAxisRaw("Vertical");
            moveInput = new Vector2(moveX, moveY).normalized;

            playerAnimator.SetFloat("Horizontal", moveX);
            playerAnimator.SetFloat("Vertical", moveY);
            playerAnimator.SetFloat("Speed", moveInput.sqrMagnitude);


        }

        if(isPlayer2){

            float moveX = Input.GetAxisRaw("Horizontal2");
            float moveY = Input.GetAxisRaw("Vertical2");
            moveInput = new Vector2(moveX, moveY).normalized;

            playerAnimator.SetFloat("Horizontal", moveX);
            playerAnimator.SetFloat("Vertical", moveY);
            playerAnimator.SetFloat("Speed", moveInput.sqrMagnitude);


        }

        if(isPlayer3){

            float moveX = Input.GetAxisRaw("Horizontal3");
            float moveY = Input.GetAxisRaw("Vertical3");
            moveInput = new Vector2(moveX, moveY).normalized;

            playerAnimator.SetFloat("Horizontal", moveX);
            playerAnimator.SetFloat("Vertical", moveY);
            playerAnimator.SetFloat("Speed", moveInput.sqrMagnitude);
        }
       
        if(isPlayer4){

            float moveX = Input.GetAxisRaw("Horizontal4");
            float moveY = Input.GetAxisRaw("Vertical4");
            moveInput = new Vector2(moveX, moveY).normalized;

            playerAnimator.SetFloat("Horizontal", moveX);
            playerAnimator.SetFloat("Vertical", moveY);
            playerAnimator.SetFloat("Speed", moveInput.sqrMagnitude);


        }



    }

    private void FixedUpdate()
    {
        playerRb.MovePosition(playerRb.position + moveInput * speed * Time.fixedDeltaTime);

    }
}
