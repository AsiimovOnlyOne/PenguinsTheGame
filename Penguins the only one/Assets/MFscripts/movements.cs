using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movements : MonoBehaviour
{
    public GameObject player;

    public Joystick joystick;

    public float moveSpeed;

    public Animator animator;

    public SpriteRenderer spriteRenderer;

    public bool isClimbingUp = false;

    public bool isClimbingDown = false;

    public Rigidbody2D rb;

    private Vector3 velocity = Vector3.zero;

    public AudioSource walk;

    public AudioSource climb;

    public int interactActive = 0;

    public int relance = 0;

    public int active = 0;

    public bool Ok = false;

    public int valeurMoveEchelle;


    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("ladderDown"))
        {
            isClimbingUp = true;
        }
        if (collision.CompareTag("ladderUp"))
        {
            isClimbingDown = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (!collision.CompareTag("ladderDown"))
        {
            isClimbingUp = false;
        }
        if (!collision.CompareTag("ladderUp"))
        {
            isClimbingDown = false;
        }
        isClimbingUp = false;
        isClimbingDown = false;
    }


    // Update is called once per frame
    void Update()
    {

        if (isClimbingUp & active == 1 & Ok)
        {
            active -= 1;
            transform.Translate(new Vector3(0, valeurMoveEchelle, 0));
            climb.Play(0);
        }
        if (isClimbingDown & active == 1 & Ok)
        {
            active -= 1;
            transform.Translate(new Vector3(0, -valeurMoveEchelle, 0));
            climb.Play(0);
        }

    }
    void FixedUpdate()
    {
        float horizontalMovement = joystick.Horizontal * moveSpeed * Time.deltaTime;

        if (horizontalMovement > 3 || horizontalMovement < 3)
        {
            MovePlayer(horizontalMovement);
        }

        Flip(rb.velocity.x);

        float characterVelocity = Mathf.Abs(rb.velocity.x);
        animator.SetFloat("Speed", characterVelocity);
    }
    void MovePlayer(float _horizontalMovement)
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            walk.Play(0);
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            walk.Play(0);
        }
        if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            walk.Pause();
        }
        if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            walk.Pause();
        }
        Vector3 targetVelocity = new Vector2(_horizontalMovement, rb.velocity.y);
        rb.velocity = Vector3.SmoothDamp(rb.velocity, targetVelocity, ref velocity, .05f);
    }
    void Flip(float _velocity)
    {
        if (_velocity > 0.1f)
        {
            spriteRenderer.flipX = false;
        }
        else if (_velocity < -0.1f)
        {
            spriteRenderer.flipX = true;
        }
    }
}
