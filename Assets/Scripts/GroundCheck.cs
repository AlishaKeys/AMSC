using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GroundCheck : MonoBehaviour {

    private Player _player;
    // Use this for initialization
    void Start()
    {
        _player = GetComponentInParent<Player>();
    }

    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.tag == "Box")
        {
            _player.jump = true;
        }
    }

    void OnTriggerExit2D(Collider2D coll)
    {
        if (coll.tag == "Box")
        {
            _player.jump = false;
        }
    }
}
