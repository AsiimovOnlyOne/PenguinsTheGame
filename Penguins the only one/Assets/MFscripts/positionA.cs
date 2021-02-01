using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class positionA : MonoBehaviour
{

    public tp teleport;

    public GameObject playerA;

    void Update()
    {
        teleport.xPlayerA = playerA.transform.position.x;

        teleport.yPlayerA = playerA.transform.position.y;
    }
}
