using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Radio : MonoBehaviour
{
    public float dist;

    private AudioSource radio;
    private AudioSource click;
    private Transform tf;

    private Transform playertf;
    // Start is called before the first frame update
    void Start()
    {
        tf = GetComponent<Transform>();
        playertf = GameObject.Find("Player").GetComponent<Transform>();
        radio = transform.parent.gameObject.GetComponent<AudioSource>();
        click = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        dist = Vector3.Distance(playertf.position, tf.position);
        if (dist < .2f && Input.GetKeyDown(KeyCode.Space))
        {
            if (radio.mute == false)
            {
                radio.mute = true;
                click.Play();
            }
            else
            {
                click.Play();
                radio.mute = false;
            }
            
        }
    }
}
