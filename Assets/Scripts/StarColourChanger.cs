using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarColourChanger : MonoBehaviour {

    public Material[] starsMaterial;

    public void ChangeColour () {
        int colour = Random.Range (0, 3);
        GetComponent<Renderer> ().material = starsMaterial[colour];

    }
}