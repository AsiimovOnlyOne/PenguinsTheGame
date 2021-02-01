using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class opaciteInteract : MonoBehaviour
{
    public GameObject interact;

    public movements movementsA;

    public movements movementsB;

    public tp tp;

    public float alpha;//half transparency
    //Get current material

    private Material matInteract;
    // Start is called before the first frame update

    // Update is called once per frame

    private void Start()
    {
        interact = gameObject;
        matInteract = interact.GetComponent<Renderer>().material;
    }
    void Update()
    {
        ChangeAlpha(matInteract, alpha);
        if (movementsA.isClimbingUp || movementsB.isClimbingUp || movementsA.isClimbingDown || movementsB.isClimbingDown || tp.teleport)
        {
            alpha = 1f;
        }
        else
        {
            alpha = 0.5f;
        }
    }

    void ChangeAlpha(Material mat, float alphaVal)
    {
        Color oldColor = mat.color;
        Color newColor = new Color(oldColor.r, oldColor.g, oldColor.b, alphaVal);
        mat.SetColor("_Color", newColor);

    }
}
