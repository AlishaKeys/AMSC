using UnityEngine;
using System.Collections;

public class ForStrel : MonoBehaviour {

    private Strelba _strel;
    // Use this for initialization
    void Start()
    {
        _strel = GetComponentInParent<Strelba>();
    }

    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D coll)
    {
      //  if (coll.tag == "Strel")
   //     {
     //       
       //     _strel.kas = true;
        //}
        //Destroy(GameObject.Find("Blood"));
    //}

//    void OnTriggerExit2D(Collider2D coll)
  //  {
    //    if (coll.tag == "Strel")
      //  {
         //   _strel.kas = false;
        //}
    }
}
