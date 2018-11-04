using UnityEngine;
using System;
using System.Collections;

public class Timer : MonoBehaviour {

    float timer = 0.0f;
    int seconds = 0;
    public float parTime = 15.0f;
    //float happening = 0;
    
    // Update is called once per frame
    void Update () {
        timer += Time.deltaTime;
        seconds = Convert.ToInt32(timer % 60);
        //Debug.Log(seconds);

        if (parTime == seconds)
        {
            timer = 0.0f;
            //Debug.Log(happening += 1);
        }
    }
}
