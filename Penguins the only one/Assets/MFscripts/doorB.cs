using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorB : MonoBehaviour
{
    public Animator animator;

    public exit exit;

    public float timer = 0.0f;

    public int level = 0;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("playerB") || collision.CompareTag("playerA"))
        {
            animator.SetFloat("stay", 0);
            timer = 0;
            animator.SetFloat("level", 2);
            level = 2;
        }

    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        animator.SetFloat("stay", 0);
        timer = 0;
        animator.SetFloat("level", -2);
        level = -2;
    }

    // Update is called once per frame
    void Update()
    {
        if (level == 2)
        {
            timer += Time.deltaTime;
            if (timer > 0.23)
            {
                animator.SetFloat("stay", 2);
                animator.SetFloat("level", 0);
                level = 0;
                exit.player2Exit = 1;
            }
        }

        if (level == -2)
        {
            timer += Time.deltaTime;
            if (timer > 0.23)
            {
                animator.SetFloat("stay", -2);
                animator.SetFloat("level", 0);
                level = 0;
                exit.player2Exit = 0;
            }
        }
    }
}
