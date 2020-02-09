using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.UI;

public class CubicleText : MonoBehaviour
{
    public GameObject player;
    public GameObject cubicle;
    public GameObject inventory;
    public Transform playertf;
    public float dist;
    public Transform textBox;
    public bool hasItem;
    public string Item;
    private Transform tf;
    public GameObject manager;
    public int check = 0;

    public bool bossGone = false;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        playertf = player.GetComponent<Transform>();
        tf = GetComponent<Transform>();
        inventory = GameObject.Find("Inventory").transform.GetChild(0).gameObject;
        cubicle = transform.parent.gameObject;
        manager = GameObject.Find("GameManager");
        textBox = cubicle.transform.GetChild(2).gameObject.GetComponent<Transform>();
        textBox.localScale = new Vector3(0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (hasItem == false)
        {
            Item = "";
        }
        dist = Vector3.Distance(playertf.position, tf.position);
        if (dist > 0 && dist < .17f)
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
            if (hasItem == true)
            {
                if (Item == "Mug")
                {
                    inventory.GetComponent<Inventory>().mugGet = true;
                    Debug.Log("Mug Get");
                    manager.GetComponent<GameManager>().jimQuestStage = 1;
                    hasItem = false;
                }
            }
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
