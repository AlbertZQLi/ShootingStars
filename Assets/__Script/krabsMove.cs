using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class krabsMove : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
    gameObject.transform.position = gameObject.transform.position + new Vector3(0.7f, 0, 0);

    if (gameObject.transform.position.x > 200f)
      Destroy(gameObject);

  }
}
