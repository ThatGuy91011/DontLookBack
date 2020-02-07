using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Inventory : MonoBehaviour
{
    public Image InvSlotImage;

    public Sprite none;

    public Sprite mug;

    public Sprite pen;

    public bool mugGet = false;

    public bool penGet = false;
    // Start is called before the first frame update
    void Start()
    {
        InvSlotImage = GameObject.Find("Inventory").transform.GetChild(0).GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        if (mugGet == true || penGet == true)
        {
            if (mugGet)
            {
                InvSlotImage.sprite = mug;
            }

            else if (penGet)
            {
                InvSlotImage.sprite = pen;
            }
        }

        else if (mugGet == false && penGet == false)
        {
            InvSlotImage.sprite = none;
        }
    }
}
