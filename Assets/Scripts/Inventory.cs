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

    public Sprite money;

    public Sprite candy;

    public Sprite sss;

    public Sprite cross;

    public bool noneGet = true;

    public bool mugGet = false;

    public bool penGet = false;

    public bool moneyGet = false;

    public bool candyGet = false;

    public bool sssGet = false;

    public bool crossGet = false;
    // Start is called before the first frame update
    void Start()
    {
        InvSlotImage = GameObject.Find("Inventory").transform.GetChild(0).GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        if (mugGet == true || penGet == true || moneyGet == true || candyGet == true || sssGet == true || crossGet == true)
        {
            if (mugGet)
            {
                InvSlotImage.sprite = mug;
            }

            else if (penGet)
            {
                InvSlotImage.sprite = pen;
            }

            else if (moneyGet)
            {
                InvSlotImage.sprite = money;
            }

            else if (candyGet)
            {
                InvSlotImage.sprite = candy;
            }

            else if (sssGet)
            {
                InvSlotImage.sprite = sss;
            }

            else if (crossGet)
            {
                InvSlotImage.sprite = cross;
            }
        }

        else if (mugGet == false && penGet == false && moneyGet == false && candyGet == false && sssGet == false && crossGet == false)
        {
            InvSlotImage.sprite = none;
        }
    }
}
