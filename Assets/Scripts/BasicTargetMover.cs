using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicTargetMover : MonoBehaviour
{
    public float spinSpeed = 180f;
    public float motionMagnitude = 0.1f;

    public bool doSpin = true;
    public bool doMotion = true;

    // Update is called once per frame
    void Update()
    {
        if (doSpin == true)
        {
            gameObject.transform.Rotate(Vector3.up * spinSpeed * Time.deltaTime); //rotates object around it's Y axis
        }
        if (doMotion == true)
        {
            gameObject.transform.Translate(Vector3.up * Mathf.Cos(Time.timeSinceLevelLoad) * motionMagnitude);
        }
    }
}
