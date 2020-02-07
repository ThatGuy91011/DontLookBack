using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubicleFrontBehind : MonoBehaviour
{
    public Transform feet;

    private Transform tf;
    // Start is called before the first frame update
    void Start()
    {
        feet = GameObject.Find("Feet").GetComponent<Transform>();
        tf = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (feet.position.y > tf.position.y)
        {
            GameObject.Find("CubicleFront").GetComponent<SpriteRenderer>().sortingOrder = 2;
        }
        else
        {
            GameObject.Find("CubicleFront").GetComponent<SpriteRenderer>().sortingOrder = 0;
        }
    }
}
