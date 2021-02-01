using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class death : MonoBehaviour
{
    public SceneManager SceneManager;
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("playerA"))
        {
            RestartLevel();
        }
        if (collision.CompareTag("playerB"))
        {
            RestartLevel();
        }

    }
    void RestartLevel() //Restarts the level
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        print("meurs");
    }
}
