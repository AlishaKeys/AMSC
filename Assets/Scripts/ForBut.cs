using UnityEngine;
using System.Collections;

public class ForBut : MonoBehaviour
{
    private Player cntrllr;

    // Use this for initialization
    void Start()
    {
        if (GameObject.Find("Isaac") != null)
        {
            if (GameObject.Find("Isaac").GetComponent<Player>() != null)
            {
                cntrllr = GameObject.Find("Isaac").GetComponent<Player>();
            }
            else
            {
                Debug.LogError("you are trying to access a non-existent component");
            }
        }
        else
        {
            Debug.LogError("the desired object can not be found");
        }
    }

    void OnMouseDown()
    {
        if (name == "Jump Button")
        {
            cntrllr.Jump();
        }
    }

    void OnMouseDrag()
    {
        if (name == "Left Button")
        {
            cntrllr.Left();
        }
        else if (name == "Right Button")
        {
            cntrllr.Right();
        }
    }

}
