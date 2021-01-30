﻿using System.Collections;
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
        
    }

    void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            activated = !activated;
            sprite.sprite = (activated? activatedSprite : deactivatedSprite);
            Debug.Log(nonogram.checkCompletion(position));
        }
        if (Input.GetMouseButtonDown(1))
        {
            crossed = !crossed;
            if (!crossed)
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

    public void setGridPos(GridPos _pos)
    {
        position = _pos;
    }
}
