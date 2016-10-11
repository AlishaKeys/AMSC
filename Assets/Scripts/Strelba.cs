using UnityEngine;
using System.Collections;

public class Strelba : MonoBehaviour
{


    public GameObject strel;
    //  private int moveSpeed = 6;
    private Player _player;
  //  public bool kas;


    void Start()
    {
        _player = GetComponentInParent<Player>();
    }

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {  
        
           // if (kas)
    //        {
                GameObject newStrel = Instantiate(strel);
                newStrel.GetComponent<CircleCollider2D>().isTrigger = true;
                newStrel.name = "Blood";
                newStrel.transform.position = new Vector2(_player.transform.position.x, _player.transform.position.y);
                newStrel.GetComponent<Rigidbody2D>().AddForce(newStrel.transform.right * 5000);
                newStrel.transform.position = new Vector2(_player.transform.position.x, _player.transform.position.y);
                Destroy(newStrel, 0.1f);

        //    }




        }

    }
}
            

