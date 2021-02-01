using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class retry : MonoBehaviour
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
            RestartLevel();
        }
    }
    void RestartLevel() //Restarts the level
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
