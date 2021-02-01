using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class push : MonoBehaviour
{
    public int active = 0;

    public int sorti = 0;

    public bool ok;

    public GameObject currentGameObject;

    public float alpha;//half transparency
    //Get current material

    private Material currentMat;

    public Animator animator;


    // Prints number of fingers touching the screen


    private void OnMouseDown()
    {
        ok = true;
        if (sorti == 1)
        {
            ok = false;
            sorti = -1;
        }
    }
    private void OnMouseUp()
    {
        sorti += 1;
    }


    void Start()
    {
        currentGameObject = gameObject;
        currentMat = currentGameObject.GetComponent<Renderer>().material;

    }

    // Update is called once per frame
    void Update()
    {
        if (ok)
        {
            active = 1;
            animator.SetFloat("Push", 2);
        }
        else
        {
            active = 0;
            animator.SetFloat("Push", 0);
        }
        ChangeAlpha(currentMat, alpha);
    }

    void ChangeAlpha(Material mat, float alphaVal)
    {
        Color oldColor = mat.color;
        Color newColor = new Color(oldColor.r, oldColor.g, oldColor.b, alphaVal);
        mat.SetColor("_Color", newColor);

    }
}