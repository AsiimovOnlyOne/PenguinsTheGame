using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class exit : MonoBehaviour
{
    public string sceneNameToLoad;

    public int player1Exit = 0;

    public int player2Exit = 0;

    // Update is called once per frame
    void Update()
    {
        if (player1Exit == 1 & player2Exit == 1)
        {
            SceneManager.LoadScene(sceneNameToLoad);
        }
    }
}
