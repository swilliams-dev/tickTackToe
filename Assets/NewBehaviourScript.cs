using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{
    string player1 = "X";
    string player2 = "O";
    bool player1turn = true;
    public void Mark()
    {
        GameObject go = EventSystem.current.currentSelectedGameObject;
        if (go != null)
        {
            
            string current = go.GetComponentsInChildren<Text>()[0].text;
            if (current == "")
            {
                {
                    if (player1turn)
                    {
                        go.GetComponentsInChildren<Text>()[0].text = player1;
                        player1turn = false;
                    }
                    else
                    {
                        go.GetComponentsInChildren<Text>()[0].text = player2;
                        player1turn = true;
                    }
                }
            }
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start!");
    }

    // Update is called once per frame
    void Update()
    {
        this.Mark();
    }
}
