using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NongramTile : MonoBehaviour
{
    public bool activated = false;
    public bool crossed = false;

    private GameObject handler;
    private Nonogram nonogram;
    public SpriteRenderer sprite;
    public Sprite activatedSprite;
    private Sprite deactivatedSprite;
    public Sprite cross;

    private bool waitForUp = false;
    private int toWait = 0;

    private GridPos position;

    // Start is called before the first frame update
    void Start()
    {
        deactivatedSprite = sprite.sprite;
        GameObject[] n = GameObject.FindGameObjectsWithTag("NonogramHandler");
        handler = n[0];
        nonogram = handler.GetComponent<Nonogram>();
    }

    // Update is called once per frame
    void Update()
    {
        if (waitForUp && Input.GetMouseButtonUp(toWait))
        {
            waitForUp = false;
        }
    }

    void OnMouseOver()
    {
        if (Input.GetMouseButton(0) && !waitForUp)
        {
            toWait = 0;
            waitForUp = true;
            activated = !activated;
            sprite.sprite = (activated? activatedSprite : deactivatedSprite);
            nonogram.checkCompletion(position);
        }
        if (Input.GetMouseButton(1) && !waitForUp)
        {
            toWait = 1;
            waitForUp = true;
            crossed = !crossed;
            if (crossed)
            {
                setTileCross();
            }
            else
            {
                sprite.sprite = deactivatedSprite;
            }

        }
    }

    public void setTileCross()
    {
        activated = false;
        sprite.sprite = cross;
        crossed = true;
    }

    public void uncrossTile()
    {
        if (crossed)
        {
            activated = false;
            sprite.sprite = deactivatedSprite;
        }
    }

    public void setGridPos(GridPos _pos)
    {
        position = _pos;
    }
}
