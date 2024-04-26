using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanging : MonoBehaviour
{
    public Material GreenMaterial;
    public Material RedMaterial;
    public Material BlueMaterial;
    public Material YellowMaterial;
    private Material PreviousMaterial;
    
    void Start()
    {
        PreviousMaterial = GetComponent<Renderer>().material;
    }

    void Update()
    {
        
    }

    public void TurnRed()
    {
        GetComponent<Renderer>().material = RedMaterial;

        PreviousMaterial = RedMaterial;
    }

    public void TurnBlue()
    {
        GetComponent<Renderer>().material = BlueMaterial;

        PreviousMaterial = BlueMaterial;
    }

    public void TurnGreen()
    {
        GetComponent<Renderer>().material = GreenMaterial;

        PreviousMaterial = GreenMaterial;
    }

    public void TurnYellow()
    {
        PreviousMaterial = GetComponent<Renderer>().material;

        GetComponent<Renderer>().material = YellowMaterial;
    }

    public void TurnPrevious()
    {
        GetComponent<Renderer>().material = PreviousMaterial;
    }

    public void TurnRandom()
    {
        int random = Random.Range(0, 4);

        switch (random)
        {
            case 0:
                TurnRed();
                break;
            case 1:
                TurnBlue();
                break;
            case 2:
                TurnGreen();
                break;
            case 3:
                TurnYellow();
                break;
        }
    }
}
