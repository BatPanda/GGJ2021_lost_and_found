using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SideBar : MonoBehaviour
{
    public GameObject textObject;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void setText(int number)
    {
        textObject.GetComponent<TextMesh>().text = number.ToString();
    }

    public void crossOut(bool cross)
    {
        textObject.GetComponent<TextMesh>().color = (cross ? Color.grey : Color.white);
    }
}
