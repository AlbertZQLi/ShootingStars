using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class garyMove : MonoBehaviour {


  int health = 1;
  public GameObject cameraM;
  // Use this for initialization
  void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
    gameObject.transform.position = gameObject.transform.position + new Vector3(-0.3f, 0, 0);

    if (gameObject.transform.position.x < -200f)
      Destroy(gameObject);

  }
  private void OnTriggerEnter(Collider other)
  {
    if (other.tag == "Bullet")
      hit(1);



  }

  public void hit(int damage)
  {


    for (int i = 0; i < damage; i++)
    {
      health--;

      if (health == 0)
      {

        cameraM.GetComponent<Main>().addScore(1);
        Destroy(gameObject);


      }


    }
  }
}
