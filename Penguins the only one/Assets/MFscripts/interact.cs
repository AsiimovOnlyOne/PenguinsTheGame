using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class interact : MonoBehaviour
{
    public int active = 0;

    public movements movementsA;

    public movements movementsB;

    public tp tp;


    // Prints number of fingers touching the screen
    private void OnMouseEnter()
    {
        movementsA.active += 1;
        movementsB.active += 1;
        tp.active += 1;
    }

    void OnMouseDown()
    {
        movementsA.Ok = true;
        movementsB.Ok = true;
        tp.Ok = true;
    }

    void OnMouseUp()
    {
        movementsA.Ok = false;
        movementsB.Ok = false;
        tp.Ok = false;
    }
    private void OnMouseExit()
    {
        movementsA.active = 0;
        movementsB.active = 0;
        tp.active = 0;

    }
}
