using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlidingDoors : MonoBehaviour
{
    public GameObject leftDoor;
    public GameObject rightDoor;

    private Animator leftAnimation;
    private Animator rightAnimation;
    // Start is called before the first frame update
    void Start()
    {

        leftAnimation = leftDoor.GetComponent<Animator>();
        rightAnimation = rightDoor.GetComponent<Animator>();
        
    }

    public void slideOpen()
    {
        leftAnimation.SetBool("Slide", true);
        rightAnimation.SetBool("Slide",true);
    }

    public void slideLeftOpen()
    {
        leftAnimation.SetBool("Slide", true);
        rightAnimation.SetBool("Slide", false);
    }

    public void slideRightOpen()
    {
        leftAnimation.SetBool("Slide", false);
        rightAnimation.SetBool("Slide", true);
    }
    public void slideClose()
    {
        leftAnimation.SetBool("Slide",false);
        rightAnimation.SetBool("Slide", false);
    }
    // Update is called once per frame
    void Update()
    {
         
        
    }
}
