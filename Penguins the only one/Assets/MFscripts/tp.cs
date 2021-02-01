using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tp : MonoBehaviour
{
    public float xPlayerA;

    public float yPlayerA;

    public float xPlayerB;

    public float yPlayerB;

    public int player1;

    public int player2;

    public GameObject playerA;

    public GameObject playerB;

    public int active = 0;

    public bool Ok = false;

    public bool teleport = false;

    void Update()
    {
        if (player1 == 1 & player2 == 1)
        {
            if (Input.GetKeyDown(KeyCode.E) || (active == 1 & Ok))
            {
                playerA.transform.position = new Vector3(xPlayerB, yPlayerB, 0);
                playerB.transform.position = new Vector3(xPlayerA, yPlayerA, 0);
            }
            teleport = true;
        }
        else
        {
            teleport = false;
        }
    }
}
