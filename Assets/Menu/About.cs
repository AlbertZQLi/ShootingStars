using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class a : MonoBehaviour {
	public Button about;
	public bool showAbout = false;
	// Use this for initialization
	void Start () {
		
		about.onClick.AddListener (onClick);

		
	}
	
	// Update is called once per frame
	void Update () {
		if (showAbout) {
			
		}
	}

	void onClick(){
		showAbout = true;
	}
}
