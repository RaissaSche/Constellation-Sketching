using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public DrawLine drawLine;

    void Start () {
        drawLine.CreateLine ();
    }

    void FixedUpdate () {
        RaycastHit hit;
        
        // Does the ray intersect any objects excluding the player layer?
        if (Physics.Raycast (transform.position, transform.TransformDirection (Vector3.forward), out hit, Mathf.Infinity)) {
            drawLine.UpdateLine (hit.point);
        }
    }

}