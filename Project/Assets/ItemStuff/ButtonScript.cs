using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour
{
    public SpriteRenderer sprite;
    private bool canClick = false;
    public bool isTake = true;
    public Item item;


    // Start is called before the first frame update
    void Start()
    {
        sprite.enabled = false;
        GetComponent<BoxCollider2D>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
     
    }

    public void setCanClick()
    {
        canClick = true;
        sprite.enabled = true;
        GetComponent<BoxCollider2D>().enabled = true;
    }

    void OnMouseOver()
    {
        if (canClick && Input.GetMouseButtonDown(0))
        {
            item.takeItem(isTake);
        }
    }
}
