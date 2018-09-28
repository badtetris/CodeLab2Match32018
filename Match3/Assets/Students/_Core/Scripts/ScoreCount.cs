using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreCount : MonoBehaviour {

    public static int scoreValue;
    Text score;

	// Use this for initialization
	void Start () {
        score = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {

        score.text = " " + scoreValue;

        if (scoreValue >= 100)
        {
            SceneManager.LoadScene(1);
        }
	}
}
