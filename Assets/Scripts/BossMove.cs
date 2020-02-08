using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class BossMove : MonoBehaviour
{
    private Transform tf;

    public enum State{ Cutscene, Idle };

    public State state;

    public float speed;

    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        tf = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        switch (state)
        {
            case State.Cutscene:
                if (tf.position != new Vector3(.7f, 0, 0))
                {
                    animator.SetBool("IsWalking", true);
                    tf.position -= tf.right * speed;
                }
                else
                {
                    animator.SetBool("IsWalking", false);
                    GameObject.Find("Sample Text Box").GetComponent<TextBox>().check = true;
                    if (Input.GetKey(KeyCode.Space))
                    {
                        GameObject.Find("Sample Text Box").GetComponent<TextBox>().check = false;
                        state = State.Idle;
                    }

                }
                break;
            case State.Idle:

                GetComponent<SpriteRenderer>().flipX = false;
                if (tf.position != new Vector3(4f, 0, 0))
                {
                    animator.SetBool("IsWalking", true);
                    tf.position += tf.right * speed;
                }
                else
                {
                    animator.SetBool("IsWalking", false);
                }
                break;
        }
    }
}
