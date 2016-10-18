using UnityEngine;
using System.Collections;

public class ForEnemy : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D ca)
    {
        if (ca.tag == "Player" || ca.tag == "Box")
        {
      //     Destroy(ca.gameObject);
        }
    }
}