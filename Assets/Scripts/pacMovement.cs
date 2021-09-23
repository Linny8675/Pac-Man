using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pacMovement : MonoBehaviour
{
    public Animator animatorController;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            animatorController.SetTrigger("W");
        }

        else if (Input.GetKeyDown(KeyCode.A))
        {
            animatorController.SetTrigger("A");
        }

        else if (Input.GetKeyDown(KeyCode.S))
        {
            animatorController.SetTrigger("S");
        }

        else if (Input.GetKeyDown(KeyCode.D))
        {
            animatorController.SetTrigger("D");
        }
        
        else if (Input.GetKeyDown(KeyCode.Space))
        {
            animatorController.SetTrigger("Space");
        }

    }
}
