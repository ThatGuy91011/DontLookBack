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
    public bool bossCheck = false;
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
        if (bossCheck)
        {
            GameObject.Find("Boss").GetComponent<Transform>().position -= tf.up * .1f;
            if (GameObject.Find("Boss").GetComponent<Transform>().position.y < -1)
            {
                Destroy(GameObject.Find("Boss"));
                System.Threading.Thread.Sleep(2000);
                Destroy(textBox);
                player.GetComponent<Controller>().state = Controller.State.Game;
            }
        }
        dist = Vector3.Distance(playertf.position, tf.position);
        if (person.name != "BossDesk")
        {
            if (dist > .1f && dist < .2f)
            {
                if (Input.GetKeyDown(KeyCode.Space))
                {
                    if (check == 0)
                    {
                        player.GetComponent<Controller>().state = Controller.State.Nothing;

                        if (inventory.GetComponent<Inventory>().mugGet && person.name == "Jim")
                        {
                            inventory.GetComponent<Inventory>().mugGet = false;
                            inventory.GetComponent<Inventory>().penGet = true;
                            manager.GetComponent<GameManager>().mikeQuestStage = 1;
                        }

                        else if (inventory.GetComponent<Inventory>().penGet && person.name == "Mike")
                        {
                            manager.GetComponent<GameManager>().jimQuestStage = 2;
                            inventory.GetComponent<Inventory>().penGet = false;
                            inventory.GetComponent<Inventory>().moneyGet = true;
                            manager.GetComponent<GameManager>().VMQuestStage = 1;
                        }

                        else if (inventory.GetComponent<Inventory>().moneyGet && person.name == "VendingMachine")
                        {
                            manager.GetComponent<GameManager>().mikeQuestStage = 2;
                            inventory.GetComponent<Inventory>().moneyGet = false;
                            inventory.GetComponent<Inventory>().candyGet = true;
                            manager.GetComponent<GameManager>().bossQuestStage = 1;
                        }

                        else if (inventory.GetComponent<Inventory>().sssGet)
                        {
                            manager.GetComponent<GameManager>().christinaQuestStage = 1;
                            inventory.GetComponent<Inventory>().sssGet = false;
                            inventory.GetComponent<Inventory>().crossGet = true;
                        }

                        else if (inventory.GetComponent<Inventory>().crossGet)
                        {
                            manager.GetComponent<GameManager>().christinaQuestStage = 2;
                        }

                        check = 1;

                    }
                    else if (check == 1)
                    {
                        player.GetComponent<Controller>().state = Controller.State.Game;
                        check = 0;
                    }
                }
            }
        }

        else
        {
            if (dist > .2f && dist < .3f)
            {
                if (Input.GetKeyDown(KeyCode.Space))
                {
                    if (check == 0)
                    {
                        player.GetComponent<Controller>().state = Controller.State.Nothing;

                        if (inventory.GetComponent<Inventory>().candyGet && person.name == "BossDesk")
                        {
                            inventory.GetComponent<Inventory>().candyGet = false;
                            manager.GetComponent<GameManager>().bossQuestStage = 1;
                            bossCheck = true;
                        }

                        else if (inventory.GetComponent<Inventory>().noneGet && GameObject.Find("Boss") == null)
                        {
                            manager.GetComponent<GameManager>().bossQuestStage = 2;
                            inventory.GetComponent<Inventory>().sssGet = true;
                            inventory.GetComponent<Inventory>().noneGet = false;
                            manager.GetComponent<GameManager>().christinaQuestStage = 1;
                        }
                        check = 1;

                    }
                    else if (check == 1)
                    {
                        player.GetComponent<Controller>().state = Controller.State.Game;
                        check = 0;
                    }
                }
            }
        }
        if (check == 1)
        {

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
