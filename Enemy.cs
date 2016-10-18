using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour
{

    private Player _player;
    public GameObject enemy;
    // Use this for initialization
    void Start()
    {
        InvokeRepeating("Blood", 1, 2);
    }

    // Update is called once per frame
    void FixedUpdate()
    {

    }

    void OnTriggerEnter2D(Collider2D ca)
    {
        if (ca.tag == "Player")
        {
            GameObject newEnemy = Instantiate(enemy);
            newEnemy.transform.position = new Vector2(0.68f, -1.23f);

            newEnemy.GetComponent<Rigidbody2D>().velocity = new Vector2(-10, 4);
            newEnemy.name = "Blood";
            Destroy(newEnemy, 0.5f);

        }

    }


    void OnTriggerExit2D(Collider2D ca)
    {
        if (ca.tag == "Player")
        {
            Destroy(enemy);

        }

    }


   

   /*     void OnTriggerStay2D(Collider2D target)
          {


              if (target.tag == "Player")
              {
          //        Destroy(target.gameObject);
                  }

           } */
    }