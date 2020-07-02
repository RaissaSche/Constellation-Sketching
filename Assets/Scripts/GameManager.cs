using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    public GameObject creditsObject;

    void Start () {
        creditsObject.GetComponent<Renderer> ().enabled = false;
    }

    public void StartGame () {
        SceneManager.LoadScene ("Constellation Sketching", LoadSceneMode.Single);
    }

    public void ExitGame () {
        Application.Quit ();
    }

    public void Credits () {
        creditsObject.GetComponent<Renderer> ().enabled = true;
    }
}