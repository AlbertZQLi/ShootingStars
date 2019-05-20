using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class player1Click : MonoBehaviour {

	public Button PLAYER1GAME;
	// Use this for initialization
	void Start () {
		PLAYER1GAME.onClick.AddListener(TaskOnClick);
	}

	// Update is called once per frame
	void Update () {
		
		
	}

	void TaskOnClick(){
		SceneManager.LoadScene("Project1");
	}
}
