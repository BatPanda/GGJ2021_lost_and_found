using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerItems : MonoBehaviour
{
    public ChecklistManager checklist;
    public List<string> itemNames;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void addItem(string item)
    {
        itemNames.Add(item);
        checklist.CompleteItem(item);
    }
}
