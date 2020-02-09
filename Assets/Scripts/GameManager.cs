using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameManager instance;

    public int jimQuestStage = 0;
    public GameObject Jim;

    public int mikeQuestStage = 0;
    public GameObject Mike;

    public int VMQuestStage = 0;
    public GameObject VM;

    public int christinaQuestStage = 0;
    public GameObject Christina;

    public int bossQuestStage = 0;
    public GameObject Boss;
    // Start is called before the first frame update
    void Start()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(this);
            Debug.LogError("Only one game manager needed");
        }


        Jim = GameObject.Find("Jim");
        Mike = GameObject.Find("Mike");
        VM = GameObject.Find("VendingMachine");
        Boss = GameObject.Find("BossDesk");
        Christina = GameObject.Find("Christina");
    }

    // Update is called once per frame
    void Update()
    {
        if (jimQuestStage == 0)
        {
            Jim.transform.GetChild(2).gameObject.GetComponent<SpriteRenderer>().sprite = Jim.transform.GetChild(1).gameObject.GetComponent<CWTalk>().normal;
        }

        else if (jimQuestStage == 1)
        {
            Jim.transform.GetChild(2).gameObject.GetComponent<SpriteRenderer>().sprite = Jim.transform.GetChild(1).gameObject.GetComponent<CWTalk>().complete;
        }

        else if (jimQuestStage == 2)
        {
            Jim.transform.GetChild(2).gameObject.GetComponent<SpriteRenderer>().sprite = Jim.transform.GetChild(1).gameObject.GetComponent<CWTalk>().after;
        }


        if (mikeQuestStage == 0)
        {
            Mike.transform.GetChild(2).gameObject.GetComponent<SpriteRenderer>().sprite = Mike.transform.GetChild(1).gameObject.GetComponent<CWTalk>().normal;
        }

        else if (mikeQuestStage == 1)
        {
            Mike.transform.GetChild(2).gameObject.GetComponent<SpriteRenderer>().sprite = Mike.transform.GetChild(1).gameObject.GetComponent<CWTalk>().complete;
        }

        else if (mikeQuestStage == 2)
        {
            Mike.transform.GetChild(2).gameObject.GetComponent<SpriteRenderer>().sprite = Mike.transform.GetChild(1).gameObject.GetComponent<CWTalk>().after;
        }


        if (VMQuestStage == 0)
        {
            VM.transform.GetChild(2).gameObject.GetComponent<SpriteRenderer>().sprite = VM.transform.GetChild(1).gameObject.GetComponent<CWTalk>().normal;
        }

        else if (VMQuestStage == 1)
        {
            VM.transform.GetChild(2).gameObject.GetComponent<SpriteRenderer>().sprite = VM.transform.GetChild(1).gameObject.GetComponent<CWTalk>().complete;
        }

        else if (VMQuestStage == 2)
        {
            VM.transform.GetChild(2).gameObject.GetComponent<SpriteRenderer>().sprite = VM.transform.GetChild(1).gameObject.GetComponent<CWTalk>().after;
        }


        if (christinaQuestStage == 0)
        {
            Christina.transform.GetChild(2).gameObject.GetComponent<SpriteRenderer>().sprite = Christina.transform.GetChild(1).gameObject.GetComponent<CWTalk>().normal;
        }

        else if (christinaQuestStage == 1)
        {
            Christina.transform.GetChild(2).gameObject.GetComponent<SpriteRenderer>().sprite = Christina.transform.GetChild(1).gameObject.GetComponent<CWTalk>().complete;
        }

        else if (christinaQuestStage == 2)
        {
            Christina.transform.GetChild(2).gameObject.GetComponent<SpriteRenderer>().sprite = Christina.transform.GetChild(1).gameObject.GetComponent<CWTalk>().after;
        }


        if (bossQuestStage == 0)
        {
            Boss.transform.GetChild(2).gameObject.GetComponent<SpriteRenderer>().sprite = Boss.transform.GetChild(1).gameObject.GetComponent<CWTalk>().normal;
        }

        else if (bossQuestStage == 1)
        {
            Boss.transform.GetChild(2).gameObject.GetComponent<SpriteRenderer>().sprite = Boss.transform.GetChild(1).gameObject.GetComponent<CWTalk>().complete;
        }

        else if (bossQuestStage == 2)
        {
            Boss.transform.GetChild(2).gameObject.GetComponent<SpriteRenderer>().sprite = Boss.transform.GetChild(1).gameObject.GetComponent<CWTalk>().after;
        }
    }
}
