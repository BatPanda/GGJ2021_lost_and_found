using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerItems : MonoBehaviour
{
    public List<string> itemNames;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void addItem(string item)
    {
        Debug.Log("ADDING ITEM");
        itemNames.Add(item);
    }
}
