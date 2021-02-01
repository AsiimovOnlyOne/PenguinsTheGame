using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class boutonExit : MonoBehaviour
{
    public int active = 0;

    public bool Ok = false;

    private void OnMouseEnter()
    {
        active = 1;
    }

    void OnMouseDown()
    {
        Ok = true;
    }

    void OnMouseUp()
    {
        Ok = false;
    }
    private void OnMouseExit()
    {
        active = 0;
    }

    void Update()
    {
        if (active == 1 & Ok)
        {
            Application.Quit();
            print("là ça part");
        }
    }
}
