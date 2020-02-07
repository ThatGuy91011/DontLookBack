using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubicleText : MonoBehaviour
{
    public GameObject player;
    public GameObject cubicle;
    public Transform playertf;
    public float dist;
    public Transform textBox;
    private Transform tf;

    public int check = 0;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        playertf = player.GetComponent<Transform>();
        tf = GetComponent<Transform>();

        cubicle = transform.parent.gameObject;

        textBox = cubicle.transform.GetChild(2).gameObject.GetComponent<Transform>();
        textBox.localScale = new Vector3(0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        dist = Vector3.Distance(playertf.position, tf.position);
        if (dist > .5f && dist < .53f)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                if (check == 0)
                {
                    player.GetComponent<Controller>().state = Controller.State.Nothing;
                    check = 1;
                }
                else if (check == 1)
                {
                    player.GetComponent<Controller>().state = Controller.State.Game;
                    check = 0;
                }
            }
        }


        if (check == 1)
        {
            if (textBox.localScale != new Vector3(.1f, .1f))
            {
                textBox.localScale += new Vector3(.01f, .01f);
            }
        }

        else if (check == 0)
        {
            if (textBox.localScale != new Vector3(0,0))
            {
                textBox.localScale -= new Vector3(.01f, .01f);
            }
        }
    }
}
