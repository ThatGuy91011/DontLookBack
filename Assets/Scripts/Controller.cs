using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public enum State { Game, Nothing };

    public State state;

    public Transform tf;

    public Animator animator;

    public float speed;

    private Rigidbody2D rb;

    private Vector2 velocity;
    // Start is called before the first frame update
    void Start()
    {
        tf = GetComponent<Transform>();
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        switch (state)
        {
            case State.Game:
                Vector2 moveInput = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
                velocity = moveInput.normalized * speed;

                if (Input.GetAxis("Horizontal") != 0 || Input.GetAxis("Vertical") != 0)
                {
                    animator.SetInteger("IsMoving", 1);
                }
                else
                {
                    animator.SetInteger("IsMoving", 0);
                }

                if (Input.GetAxis("Horizontal") > 0)
                {
                    GetComponent<SpriteRenderer>().flipX = false;
                }
                else if (Input.GetAxis("Horizontal") < 0)
                {
                    GetComponent<SpriteRenderer>().flipX = true;
                }
                break;
            case State.Nothing:
                animator.SetInteger("IsMoving", 0);
                break;
        }
        
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + velocity * Time.deltaTime);
    }
}
