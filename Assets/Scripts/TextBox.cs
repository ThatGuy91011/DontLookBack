using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextBox : MonoBehaviour
{
    public Transform tf;

    public bool check = false;
    // Start is called before the first frame update
    void Start()
    {
        tf = GetComponent<Transform>();
        tf.localScale = new Vector3(0,0,0);
    }

    // Update is called once per frame
    void Update()
    {
        if (check == true)
        {
            if (tf.localScale != new Vector3(.1f, .1f))
            {
                tf.localScale += new Vector3(.01f, .01f);
            }
        }
        else
        {
            if (tf.localScale != new Vector3(0, 0))
            {
                tf.localScale -= new Vector3(.01f, .01f);
            }
        }
    }
}
