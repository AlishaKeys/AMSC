using UnityEngine;
using System.Collections;

public class Strelba : MonoBehaviour {

    
    public GameObject strel;
  //  private int moveSpeed = 6;
    private Player _player;


    void Start ()
    {
        _player = GetComponentInParent<Player>();
    }
    void FixedUpdate()
    { 
        if (Input.GetKey(KeyCode.RightArrow))
        {
            GameObject newStrel = Instantiate(strel);
            newStrel.AddComponent<CircleCollider2D>();
            newStrel.AddComponent<Rigidbody2D>();
            newStrel.name = "Blood";
            newStrel.transform.position = new Vector2(_player.transform.position.x, _player.transform.position.y);
            newStrel.GetComponent<Rigidbody2D>().AddForce(Vector3.forward);
            newStrel.GetComponent<Rigidbody2D>().isKinematic = true;

            // newStrel.transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
        }
            
    }



    //иницил объект, содаем его, прописываем условие нажатие на клавишу, создаем коллайдер, красим в цвет, если каается с землей, то дестрой
}


