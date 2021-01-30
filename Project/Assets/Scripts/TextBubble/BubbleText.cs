﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubbleText : MonoBehaviour
{

    public TextMesh text;
    public SpriteRenderer bubble;
    private Vector2 baseSize;
    public int offSet = 50;
    public float yOffset = 0.26f;
    public float maxSize = 4;

    void Start()
    {
        baseSize = bubble.size;
        this.updateText("example text. WARNING. this is an example text");
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            flipTextBubble(false);
        }
        if (Input.GetMouseButtonDown(1))
        {
            flipTextBubble(true);
        }
    }

    public void flipTextBubble(bool pointingRight)
    {
        if (bubble.flipX == pointingRight)
         {
             if (!bubble.flipX)
             {
                 bubble.transform.position = new Vector3(bubble.transform.position.x - bubble.size.x * bubble.transform.localScale.x, bubble.transform.position.y, bubble.transform.position.z);
                 text.transform.position = new Vector3(text.transform.position.x + bubble.size.x * bubble.transform.localScale.x, text.transform.position.y, text.transform.position.z);
             }
             else
             {
                 bubble.transform.position = new Vector3(bubble.transform.position.x + bubble.size.x * bubble.transform.localScale.x, bubble.transform.position.y, bubble.transform.position.z);
                 text.transform.position = new Vector3(text.transform.position.x - bubble.size.x * bubble.transform.localScale.x, text.transform.position.y, text.transform.position.z);
             }
         }
        bubble.flipX = !pointingRight;

        
    }

    public void updateText(string _text)
    {
        int cutting = 0;
        text.text = _text;
        var width = calculateLengthOfText(_text) + offSet;
        if (width > maxSize * 1000)
        {
            cutting = (int)(width / (maxSize * 1000));
            (int, string) newText = cutMessage(_text, cutting);
            text.text = newText.Item2;
            width = newText.Item1 + offSet * 2;
        }
        Debug.Log(width);
        bubble.size = new Vector2(width * 0.001f, yOffset + cutting * 0.12f);
    }

    private (int, string) cutMessage(string message, int amountToCut)
    {
        Debug.Log(amountToCut);
        amountToCut ++;

        int lastPos = 0;
        int longestText = 0;
        for (int cut = 1; cut < amountToCut; cut++)
        {
            var continueLoop = true;
            for (int i = (int)(cut * (message.Length/amountToCut)) - 1; i < message.Length && continueLoop; i++)
            {
                if (message[i] == ' ')
                {
                    int length = calculateLengthOfText(message.Substring(lastPos, (i - lastPos)));
                    if (length > longestText)
                    {
                        longestText = length;
                    }
                    lastPos = i;
                    continueLoop = false;
                    message = message.Insert(i, "\n");
                    Debug.Log("CUT");
                }
            }
        }
        return (longestText, message);
    }

    private int calculateLengthOfText(string message)
    {
        int totalLength = 0;

        Font myFont = text.font;  //chatText is my Text component
        CharacterInfo characterInfo = new CharacterInfo();

        char[] arr = message.ToCharArray();

        foreach (char c in arr)
        {
            myFont.GetCharacterInfo(c, out characterInfo, text.fontSize);

            totalLength += characterInfo.advance;
        }

        return totalLength;
    }
}
