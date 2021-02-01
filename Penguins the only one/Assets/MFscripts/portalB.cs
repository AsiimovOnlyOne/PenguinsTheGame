using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class portalB : MonoBehaviour
{

    public tp teleport;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("playerA"))
        {
            teleport.player2 = 1;
        }
        if (collision.CompareTag("playerB"))
        {
            teleport.player2 = 1;
        }

    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        teleport.player2 = 0;
    }
}
