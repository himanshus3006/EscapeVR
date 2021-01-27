using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.Remoting.Messaging;
using TMPro;
using UnityEngine;
using UnityEngine.Rendering;

public class ColorChanger : MonoBehaviour
{
    public List<Material> materials;
    public bool isBlue;
    public bool isRed ;
    public bool isYellow;
    public bool isWhite;

    int matIndex = 0;



     void Start()
    {
      isBlue = false;
     isRed = false;
     isYellow = false;
     isWhite = false;


}

// Returns next color in the list
public Material GetNextMaterial()
    {
        // Get the color at colorIndex in the list
        Material nextMaterial = materials[matIndex];

        // If we are less than the last index
        if (matIndex < materials.Count - 1)
        {
            // Add one
            matIndex++;
        }
        else
        {
            // Otherwise restart
            matIndex = 0;
        }
        // Return the chosen color
        return nextMaterial;
    }

    // Attach this function to OnClick in the inspector
    public void ChangeColor()
    {
        // Set the button's color to GetNextColor();
        GetComponent<Renderer>().material = GetNextMaterial();
    }


    public void Update()
    {
        // Get the color at colorIndex in the list
        Material nextMaterial = materials[matIndex];
        
        // update the current color
        if (nextMaterial == materials[0])
        {
            isBlue = true;
            isRed = false;
            isYellow = false;
            isWhite = false;
      
        }
        else if (nextMaterial == materials[1])
        {
            isBlue = false;
            isRed = true;
            isYellow = false;
            isWhite = false;
            
        }


        else if (nextMaterial == materials[2])
        {
            isBlue = false;
            isRed = false;
            isYellow = true;
            isWhite = false;

        }


        else if (nextMaterial == materials[3])
        {
            isBlue = false;
            isRed = false;
            isYellow = false;
            isWhite = true;
        }

    }

}

