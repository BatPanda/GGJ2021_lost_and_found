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

    public List<string> win;
    public List<bool> winb;

    public List<string> partial;
    public List<bool> partialb;

    public List<string> lose;
    public List<bool> loseb;



    public List<string> endConversationText;
    public List<bool> endChildTalking;

    private int conversationPlace = 0;
    private bool completed = false;
    private bool convoEnd = false;

    // Start is called before the first frame update
    void Start()
    {
        nextConversation(conversationText, childTalking);
    }

    // Update is called once per frame
    void Update()
    {
        if (!completed && Input.GetMouseButtonDown(0))
        {
            if (convoEnd)
            {
                nextConversation(endConversationText, endChildTalking);
            }
            else
            {
                nextConversation(conversationText, childTalking);
            }
        }
    }

    private void nextConversation(List<string> conversation, List<bool> conversationC)
    {
        if (conversationPlace < conversation.Count)
        {
            if (conversationC[conversationPlace])
            {
                playerText.updateText(conversation[conversationPlace]);
                if (!playerText.visible) playerText.setVisibility(true);
                if (parentText.visible) parentText.setVisibility(false);
            }
            else
            {
                parentText.updateText(conversation[conversationPlace]);
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

    public void end()
    {
        timer.ended = true;
        conversationPlace = 0;
        completed = false;
        convoEnd = true;
        move.setInGame(false);
        //nextConversation(endConversationText, endChildTalking);
        Debug.Log("GAME END");
    }
}
