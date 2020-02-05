using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public enum State{ Cutscene, Game, Nothing };

    public State state;

    public Transform tf;

    public float speed = .05f;

    public int check;
    public Animator animator;
    private int cutsceneState = 0;
    private int currentWaypoint = 0;
    // Start is called before the first frame update
    void Start()
    {
        tf = GetComponent<Transform>();
        switch (state)
        {
            case State.Cutscene:
                check = 1;
                break;
            case State.Game:
                check = 2;
                break;
            case State.Nothing:
                break;
        }
    }


    // Update is called once per frame
    void Update()
    {
        if (check == 1)
        {
            if (cutsceneState == 0)
            {
                if (tf.position != new Vector3(0, 1, 0))
                {
                    tf.position += tf.up * speed;
                }
                else
                    cutsceneState = 2;
            }
            else if (cutsceneState == 1)
            {
                if (tf.position != new Vector3(1, 1, 0))
                {
                    tf.position += tf.right * speed;
                }
                else
                    check = 2;
            }
            else if (cutsceneState == 2)
            {
                System.Threading.Thread.Sleep(2000);
                cutsceneState = 1;
            }
        }

        else if (check == 2)
        {
            if (Input.GetKey(KeyCode.UpArrow))
            {
                animator.SetInteger("IsMoving", 1);
                tf.position += tf.up * speed;
            }
            else if (Input.GetKey(KeyCode.RightArrow))
            {
                animator.SetInteger("IsMoving", 1);
                tf.position += tf.right * speed;
            }
            else if (Input.GetKey(KeyCode.DownArrow))
            {
                animator.SetInteger("IsMoving", 1);
                tf.position -= tf.up * speed;
            }
            else if (Input.GetKey(KeyCode.LeftArrow))
            {
                animator.SetInteger("IsMoving", 1);
                tf.position -= tf.right * speed;
            }
            else
                animator.SetInteger("IsMoving", 0);
        }
        
    }

    IEnumerator Wait()
    {
        Debug.Log("In Function");
        yield return new WaitForSecondsRealtime(2);
    }
}
