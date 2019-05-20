using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CONTROLGUIDE : MonoBehaviour {
	public Button CONTROL;
	// Use this for initialization
	void Start () {
		CONTROL.onClick.AddListener (onClick);	
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void onClick(){
		Debug.Log ("show guide!");
	}
}
