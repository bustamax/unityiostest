﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
 
public class Slots : MonoBehaviour {
 
    public Reel[] reel;
    bool startSpin;
 
    // Use this for initialization
    void Start ()
    {
        startSpin = false;
    }
     
    // Update is called once per frame
    void Update ()
    {
        if (!startSpin)//Prevents Interference If The Reels Are Still Spinning
        {
            if (CrossPlatformInputManager.GetButtonDown("Jump"))//The Input That Starts The Slot Machine
            {
                startSpin = true;
                StartCoroutine(Spinning());
            }
        }
    }
 
    IEnumerator Spinning()
    {
        foreach (Reel spinner in reel)
        {
            //Tells Each Reel To Start Spnning
            spinner.spin = true;
        }
 
        for(int i = 0; i < reel.Length; i++)
        {
            //Allow The Reels To Spin For A Random Amout Of Time Then Stop Them
            yield return new WaitForSeconds(Random.Range(1, 3));
            reel[i].spin = false;
            reel[i].RandomPosition();
        }
 
        //Allows The Machine To Be Started Again
        startSpin = false;
    }
}