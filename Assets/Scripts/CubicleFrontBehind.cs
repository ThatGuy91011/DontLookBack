using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubicleFrontBehind : MonoBehaviour
{
    public Transform feet;
    public GameObject thing;
    private Transform tf;
    // Start is called before the first frame update
    void Start()
    {
        feet = GameObject.Find("Feet").GetComponent<Transform>();
        tf = GetComponent<Transform>();
        thing = transform.parent.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        if (feet.position.y > tf.position.y)
        {
            thing.GetComponent<SpriteRenderer>().sortingOrder = 2;
        }
        else
        {
            thing.GetComponent<SpriteRenderer>().sortingOrder = 0;
        }
    }
}
