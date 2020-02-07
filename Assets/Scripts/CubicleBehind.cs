using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubicleBehind : MonoBehaviour
{
    public Transform feet;
    public GameObject cubicle;
    private Transform tf;
    // Start is called before the first frame update
    void Start()
    {
        feet = GameObject.Find("Feet").GetComponent<Transform>();
        tf = GetComponent<Transform>();
        cubicle = transform.parent.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        if (feet.position.y > tf.position.y)
        {
            cubicle.GetComponent<SpriteRenderer>().sortingOrder = 2;
        }
        else
        {
            cubicle.GetComponent<SpriteRenderer>().sortingOrder = 0;
        }
    }
}
