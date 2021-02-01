using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class caisse : MonoBehaviour
{
    public Animator animator;

    public GameObject caisseObject;

    public Rigidbody2D caisseMove;

    public float posActuel;

    public int active;

    public bool push;

    public bool free = false;

    public bool playerB = false;

    public BoxCollider2D caisseDetector;



    void Update()
    {
        if (free)
        {
            caisseMove.constraints = RigidbodyConstraints2D.None;
        }
        else
        {
            caisseMove.constraints = RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezePositionY;
            active = 0;
        }
        if (Input.GetKey(KeyCode.F) || (playerB))
        {
            caisseMove.constraints = RigidbodyConstraints2D.FreezeRotation;
            active = 1;
            animator.SetFloat("Push", 2);
        }
    }

    private void Start()
    {
        caisseMove.constraints = RigidbodyConstraints2D.None;
        caisseMove.constraints = RigidbodyConstraints2D.FreezePositionX;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("hollow"))
        {
            print("baragouin");
            free = true;
            caisseDetector.enabled = false;
        }
        if (collision.CompareTag("playerB"))
        {
            playerB = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        playerB = false;
        animator.SetFloat("Push", 0);
    }
}
