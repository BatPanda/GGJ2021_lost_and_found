using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextHandler : MonoBehaviour
{
    public TimerHandler timer;
    public PlayerMovement move;

    public BubbleText playerText;
    public BubbleText parentText;

    public List<string> conversationText;
    public List<bool> childTalking;

    private int conversationPlace = 0;
    private bool completed = false;

    // Start is called before the first frame update
    void Start()
    {
        nextConversation();
    }

    // Update is called once per frame
    void Update()
    {
        if (!completed && Input.GetMouseButtonDown(0))
        {
            nextConversation();
        }
    }

    private void nextConversation()
    {
        if (conversationPlace < conversationText.Count)
        {
            if (childTalking[conversationPlace])
            {
                playerText.updateText(conversationText[conversationPlace]);
                if (!playerText.visible) playerText.setVisibility(true);
                if (parentText.visible) parentText.setVisibility(false);
            }
            else
            {
                //parentText.flipTextBubble(true);
                parentText.updateText(conversationText[conversationPlace]);
                if (playerText.visible) playerText.setVisibility(false);
                if (!parentText.visible) parentText.setVisibility(true);
                parentText.flipTextBubble(false);
            }
            conversationPlace++;
        }
        else
        {
            playerText.setVisibility(false);
            parentText.setVisibility(false);
            move.setInGame(true);
            move.totalMarkers = timer.startTimer();
            completed = true;
        }
    }
}
