using UnityEngine;
using System.Collections;

public class Timer : MonoBehaviour {

    float totalTime = 0.0f;
	
	// Update is called once per frame
	void Update () {
        totalTime += Time.deltaTime;
        Debug.Log(totalTime);
	}
}
