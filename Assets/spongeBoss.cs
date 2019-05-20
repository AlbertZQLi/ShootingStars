using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spongeBoss : MonoBehaviour {

  GameObject gary;
  public GameObject garyPreFab;

  GameObject krabs;
  public GameObject krabsPreFab;
  int count;

  int state;

  // Use this for initialization
  void Start () {
    count = 0;
    state = 1;
  }
	
	// Update is called once per frame
	void Update () {


    count++;

    if (count >= 1000 ) {
      action();
      count = 0;
    }


  }

  void action() {
    if (state == 1)
    {
      if (Random.Range(0, 2) == 1)
      {
        useKrabs();

      }
      else
      {
        useGary();

      }
    }
    else {

      useJellyFish();

    }
    

  }

  void useKrabs() {
    krabs = Instantiate(krabsPreFab);
    krabs.transform.position = new Vector3(-5.5f, -10f, 0f);
  }

  void useGary() {
    krabs = Instantiate(krabsPreFab);
    krabs.transform.position = new Vector3(5.5f, 0f, 0f);
  }

  void useJellyFish() {
  }

  //public void changeState() {
  //  state = 0;
  //}
}
