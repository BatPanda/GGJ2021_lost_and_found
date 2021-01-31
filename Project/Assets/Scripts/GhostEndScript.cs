using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostEndScript : MonoBehaviour
{
    public BubbleText text;
    public ButtonScript yesButton;
    public ButtonScript noButton;

    public string endText;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void hideButtons()
    {
        yesButton.setCantClick();
        noButton.setCantClick();
        text.setVisibility(false);
    }

    void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            text.setVisibility(true);
            text.updateText(endText);
            text.flipTextBubble(false);
            yesButton.setCanClick();
            noButton.setCanClick();
        }
    }

}
