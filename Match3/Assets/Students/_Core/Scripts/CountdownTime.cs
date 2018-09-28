using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CountdownTime : MonoBehaviour {
    //making a countdown timer
    public float startingTime;
    private Text theText;

    void Start()
    {

        theText = GetComponent<Text>();
        
    }
    
    void Update()
    {

        startingTime -= Time.deltaTime; //counts down from the starting time
        theText.text = "" + Mathf.Round (startingTime); //Using Matf rounds the numbers counting down
        if (startingTime < 0)
            startingTime = 0;
        
        
        if (startingTime == 0)
        {
            SceneManager.LoadScene(2);
        }
        
    }


}
