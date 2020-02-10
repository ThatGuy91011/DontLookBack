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
        cutsceneTimer = 0.0f;
        //grabs display's spriterender
        display = GetComponentInChildren<SpriteRenderer>();
        //starts off with the first scene
        display.sprite = firstCutscene[0];
    }

    // Update is called once per frame
    void Update()
    {
        //substraces timer relative to real time
        cutsceneTimer += Time.deltaTime;
        time = (int)Math.Ceiling(cutsceneTimer);
        Debug.Log("Timer is at: " + time + " Seconds.");
        // whenever the timer is divisible by ten, it'll go to the next scene
        if (time == 2)
            display.sprite = firstCutscene[1];
        else if (time == 5)
            display.sprite = firstCutscene[2];
        else if (time == 8)
            display.sprite = firstCutscene[3];
        else if (time == 10)
            display.sprite = firstCutscene[4];
        else if (time == 12)
            display.sprite = firstCutscene[5];
        else if (time == 13)
            display.sprite = firstCutscene[6];
        else if (time ==14 )
            display.sprite = firstCutscene[7];
        else if (time == 15)
            display.sprite = firstCutscene[8];
        else if (time == 16)
            display.sprite = firstCutscene[9];
        else if (time == 17)
            display.sprite = firstCutscene[10];
        else if (time == 18)
            display.sprite = firstCutscene[11];
        else if (time == 20)
            display.sprite = firstCutscene[12];
        else if (time == 21)
            display.sprite = firstCutscene[13];
        else if (time == 23)
            display.sprite = firstCutscene[14];
        else if (time == 24)
            display.sprite = firstCutscene[15];
        else if (time == 25)
            display.sprite = firstCutscene[16];
        else if (time == 27)
            display.sprite = firstCutscene[17];
        else if (time == 29)
            display.sprite = firstCutscene[18];
        else if (time == 31)
            display.sprite = firstCutscene[19];
        //else if (time == 240)
        //    display.sprite = firstCutscene[20];
        //else if (time == 235)
        //    display.sprite = firstCutscene[21];
        //else if (time == 230)
        //    display.sprite = firstCutscene[22];
        //else if (time == 225)
        //    display.sprite = firstCutscene[23];
        //else if (time == 220)
        //    display.sprite = firstCutscene[24];
        //else if (time == 215)
        //    display.sprite = firstCutscene[25];
        //else if (time == 210)
        //    display.sprite = firstCutscene[26];
        //else if (time == 205)
        //    display.sprite = firstCutscene[27];
        //else if (time == 200)
        //    display.sprite = firstCutscene[28];
        //else if (time == 195)
        //    display.sprite = firstCutscene[29];
        //else if (time == 190)
        //    display.sprite = firstCutscene[30];
        //else if (time == 185)
        //    display.sprite = firstCutscene[31];
        //else if (time == 180)
        //    display.sprite = firstCutscene[32];
        //else if (time == 175)
        //    display.sprite = firstCutscene[33];
    }
}
