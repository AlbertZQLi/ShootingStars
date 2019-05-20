using System.Collections;
using System.Collections.Generic;
using UnityEngine; 

public class gunUpGrades : MonoBehaviour {

    GameObject camera;

	// Use this for initialization
	void Start () {

        camera = GameObject.FindGameObjectWithTag("MainCamera");    
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void upgrade(int i)
    {
    if (i == 1)
      GameObject.Find("Gun1").GetComponent<weapon>().addAmmo();
    else
      GameObject.Find("Gun2").GetComponent<weapon>().addAmmo();
    }

}
