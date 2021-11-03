using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PacStudentMovement : MonoBehaviour
{
    /**
    private int lastTime = 0;
    private float timer = 0;
    **/
    private Vector3 currentPos;
    private Vector3 posOne;
    //Animator pacStudent;
    // Start is called before the first frame update
    void Start()
    {
        currentPos = new Vector3(transform.position.x, transform.position.y);
        posOne = new Vector3(20f, transform.position.y);
        // StartCoroutine(right());
    }

    // Update is called once per frame
    void Update()
    {
        /**
        timer += Time.deltaTime;
        if (lastTime == (int)timer)
        {
            lastTime++;
        }
        **/
        transform.position = Vector3.Lerp(currentPos, posOne, Time.time / 5);
    }
}
