using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class caisseBlock : MonoBehaviour
{

    public BoxCollider2D passage;

    public BoxCollider2D wall;

    public float timer;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("caisse"))
        {
            wall.enabled = false;
            timer += Time.deltaTime;
            passage.enabled = true;
            print("Good");
        }

    }
}
