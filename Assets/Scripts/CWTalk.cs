using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CWTalk : MonoBehaviour
{
    public GameObject player;
    public GameObject person;
    public GameObject inventory;
    public Transform playertf;
    public float dist;
    public GameObject textBox;
    public Transform textBoxtf;
    public Sprite normal;
    public Sprite complete;
    public Sprite after;
    public GameObject manager;
    private Transform tf;

    public int check = 0;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        playertf = player.GetComponent<Transform>();
        tf = GetComponent<Transform>();
        inventory = GameObject.Find("Inventory").transform.GetChild(0).gameObject;
        person = transform.parent.gameObject;
        textBox = person.transform.GetChild(2).gameObject;
        textBoxtf = textBox.GetComponent<Transform>();
        textBoxtf.localScale = new Vector3(0, 0);

        manager = GameObject.Find("GameManager");
    }

    // Update is called once per frame
    void Update()
    {
        dist = Vector3.Distance(playertf.position, tf.position);
        if (dist > .1f && dist < .2f)
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
            if (manager.GetComponent<GameManager>().jimQuestStage == 2)
            {
                textBox.GetComponent<SpriteRenderer>().sprite = after;

            }

            if (manager.GetComponent<GameManager>().jimQuestStage == 1)
            {
                textBox.GetComponent<SpriteRenderer>().sprite = complete;
                inventory.GetComponent<Inventory>().mugGet = false;
                inventory.GetComponent<Inventory>().penGet = true;
            }

            if (manager.GetComponent<GameManager>().jimQuestStage == 0)
            {
                textBox.GetComponent<SpriteRenderer>().sprite = normal;
            }



            if (textBoxtf.localScale != new Vector3(.1f, .1f))
            {
                textBoxtf.localScale += new Vector3(.01f, .01f);
            }

        }

        else if (check == 0)
        {

            if (textBoxtf.localScale != new Vector3(0, 0))
            {
                textBoxtf.localScale -= new Vector3(.01f, .01f);
            }
        }
    }
}
