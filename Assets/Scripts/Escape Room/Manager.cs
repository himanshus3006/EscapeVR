using System.Collections;
using System.Collections.Generic;
using System.Xml.Schema;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public GameObject red;
    public GameObject yellow;
    public GameObject blue;
    public GameObject white;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (red.GetComponentInChildren<ColorChanger>().isRed == true && yellow.GetComponentInChildren<ColorChanger>().isYellow == true && blue.GetComponentInChildren<ColorChanger>().isBlue == true && white.GetComponentInChildren<ColorChanger>().isWhite)
        {
            GetComponent<SlidingDoors>().slideOpen();
            Debug.Log("Open");
        }
        
    }
}
