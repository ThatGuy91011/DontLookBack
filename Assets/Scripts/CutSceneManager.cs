using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutSceneManager : MonoBehaviour
{
    //first cutscene scenes array
    public Sprite[] firstCutscene;

    public SpriteRenderer display;

    public float cutsceneTimer;

    public int sceneNum = 0;
    public int time;
    // Start is called before the first frame update
    void Start()
    {
        // intializes timer
        cutsceneTimer = 340.0f;
        //grabs display's spriterender
        display = GetComponentInChildren<SpriteRenderer>();
        //starts off with the first scene
        display.sprite = firstCutscene[0];
    }

    // Update is called once per frame
    void Update()
    {
        //substraces timer relative to real time
        cutsceneTimer -= Time.deltaTime;
        time = (int)Math.Ceiling(cutsceneTimer);
        Debug.Log("Timer is at: " + time + " Seconds.");
        // whenever the timer is divisible by ten, it'll go to the next scene
        if (time == 330)
            display.sprite = firstCutscene[1];
        else if(time == 320)
            display.sprite = firstCutscene[2];
        else if (time == 310)
            display.sprite = firstCutscene[3];
        else if (time == 300)
            display.sprite = firstCutscene[4];
        else if (time == 290)
            display.sprite = firstCutscene[5];
        else if (time == 280)
            display.sprite = firstCutscene[6];
        else if (time == 270)
            display.sprite = firstCutscene[7];
        else if (time == 260)
            display.sprite = firstCutscene[8];
        else if (time == 250)
            display.sprite = firstCutscene[9];





    }
}
