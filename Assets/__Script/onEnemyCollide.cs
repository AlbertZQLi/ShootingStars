using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onEnemyCollide : MonoBehaviour {
  int i;

  // Use this for initialization
  void Start () {


  }

    void OnTriggerEnter(Collider other)
    {



    if (other.tag == "Player")
        {

      if (other.name == "_Hero")
        i = 1;
      else
        i = 2;


        GameObject.Find("Shield"+i.ToString()).GetComponent<shield>().shieldHit(1);


    }
    }

    // Update is called once per frame
    void Update () {

  }
}
