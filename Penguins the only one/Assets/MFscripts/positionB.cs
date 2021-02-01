using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class positionB : MonoBehaviour
{
    public tp teleport;

    public GameObject playerB;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        teleport.xPlayerB = playerB.transform.position.x;

        teleport.yPlayerB = playerB.transform.position.y;
    }
}
