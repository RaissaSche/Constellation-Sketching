using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawLine : MonoBehaviour {
    public GameObject linePrefab;
    public GameObject currentLine;

    public LineRenderer lineRenderer;
    public List<Vector3> gvrPositions;

    public void CreateLine () {
        currentLine = Instantiate (linePrefab, Vector3.zero, Quaternion.identity);
        lineRenderer = currentLine.GetComponent<LineRenderer> ();
        gvrPositions.Clear ();

        //even a dot has two positions
        gvrPositions.Add (new Vector3 (-1.54f, -3.8f, 0.39f));
        gvrPositions.Add (new Vector3 (-1.54f, -3.8f, 0.41f));

        //setting first two positions
        lineRenderer.SetPosition (0, gvrPositions[0]);
        lineRenderer.SetPosition (1, gvrPositions[1]);
    }

    public void UpdateLine (Vector3 newGvrPos) {
        if (Vector3.Distance (newGvrPos, gvrPositions[gvrPositions.Count - 1]) >.1f) {
            gvrPositions.Add (newGvrPos);
            lineRenderer.positionCount++;
            lineRenderer.SetPosition (lineRenderer.positionCount - 1, newGvrPos);
        }
    }

}