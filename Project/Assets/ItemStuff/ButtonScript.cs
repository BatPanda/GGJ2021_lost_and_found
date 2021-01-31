using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour
{
    public SpriteRenderer sprite;
    private bool canClick = false;
    public bool isTake = true;
    public bool isEnd = false;
    public TextHandler textHandler;
    public GhostEndScript ghost;
    public Item item;


    // Start is called before the first frame update
    void Start()
    {
        sprite.enabled = false;
        GetComponent<BoxCollider2D>().enabled = false;

        if (isEnd)
        {
            GameObject[] n = GameObject.FindGameObjectsWithTag("TextHandler");
            textHandler = n[0].GetComponent<TextHandler>();
        }
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

    public void setCantClick()
    {
        canClick = false;
        sprite.enabled = false;
        GetComponent<BoxCollider2D>().enabled = false;
    }

    void OnMouseOver()
    {
        if (canClick && Input.GetMouseButtonDown(0))
        {
            if (isEnd)
            {
                if (isTake)
                {
                    textHandler.end();
                }
                ghost.hideButtons();
            }
            else
            {
                item.takeItem(isTake);
            }
        }
    }
}
