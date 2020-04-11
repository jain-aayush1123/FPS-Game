﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicMover : MonoBehaviour
{

    public float spinSpeed = 180.0f;
    public float motionSpeed = 0.1f;
    public bool doSpin = true;
    public bool doMove = true;


    // Update is called once per frame
    void Update()
    {
        if (doSpin)
        {
            gameObject.transform.Rotate(Vector3.up * spinSpeed * Time.deltaTime);
        }
        if (doMove)
        {
            gameObject.transform.Translate(Vector3.up * Mathf.Cos(Time.timeSinceLevelLoad) * motionSpeed);
        }
    }
}
