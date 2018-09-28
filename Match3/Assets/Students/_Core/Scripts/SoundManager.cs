using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour {

    public static AudioClip matchSound;
    static AudioSource audioSrc;

    // Use this for initialization
    void Start () {

        matchSound = Resources.Load<AudioClip>("Sounds/Matched");

        audioSrc = GetComponent<AudioSource>();

    }
	
	// Update is called once per frame
	void Update () {
		


	}

    public static void PlaySound(string clip)
    {
        switch (clip)
        {
            case "MadeMatch":
                audioSrc.PlayOneShot(matchSound);
                break;

        }
    }

}
