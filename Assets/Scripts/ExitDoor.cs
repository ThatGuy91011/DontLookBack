using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitDoor : MonoBehaviour
{
    public GameObject player;
    public Transform textBoxTF;
    private int check;
    private Transform playertf;

    private Transform tf;

    public float dist;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        playertf = player.GetComponent<Transform>();
        tf = GetComponent<Transform>();
        textBoxTF = transform.parent.gameObject.transform.GetChild(1).gameObject.GetComponent<Transform>();
        textBoxTF.localScale = new Vector3(0,0);
    }

    // Update is called once per frame
    void Update()
    {
        dist = Vector3.Distance(playertf.position, tf.position);

        if (dist > .17f && dist < .21f)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                if (check == 0)
                {
                    player.GetComponent<Controller>().state = Controller.State.Nothing;
                    check = 1;
                }
            }
            if (Input.GetKey(KeyCode.Y))
            {
                if (GameObject.Find("Inventory").transform.GetChild(0).gameObject.GetComponent<Inventory>()
                    .crossGet)
                {
                    SceneManager.LoadScene("Win");
                }
                else
                {
                    SceneManager.LoadScene("Lose");
                }
            }
            else if (Input.GetKey(KeyCode.N))
            {
                Debug.Log("No");
                player.GetComponent<Controller>().state = Controller.State.Game;
                check = 0;
            }


        }

        if (check == 1)
        {

            if (textBoxTF.localScale != new Vector3(.1f, .1f))
            {
                textBoxTF.localScale += new Vector3(.01f, .01f);
            }

        }

        else if (check == 0)
        {

            if (textBoxTF.localScale != new Vector3(0, 0))
            {
                textBoxTF.localScale -= new Vector3(.01f, .01f);
            }
        }
    }
}
