using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Main : MonoBehaviour {

    public float camWidth;
    public float camHeight;
    public Camera camera;
    public GameObject enemy1;
    public GameObject enemy1PreFab;
    public GameObject enemy0;
    public GameObject enemy0PreFab;
    public int counter1;
    public int counter0;
    int playerState = 2;
    int score;
    int highScore;

    GameObject shield;


    int weaponState;



    Vector3 ypos;


    // Use this for initialization
    void Start() {
        camWidth = camera.orthographicSize * camera.aspect;
        camHeight = camera.orthographicSize;



        score = 0;


        ypos = new Vector3(0, camHeight + 10, 0);


    }

    void spawnEnemy0() {
        
        enemy0 = Instantiate(enemy0PreFab, ypos, Quaternion.identity);

    }

    void spawnEnemy1() {
        enemy1 = Instantiate(enemy1PreFab, ypos, Quaternion.identity);
    }

	// Update is called once per frame
	void Update () {

        if (score >= 50)
        {
            SceneManager.LoadScene("Project2", LoadSceneMode.Single);

        }

        highScore = PlayerPrefs.GetInt("highScore", highScore);

        if (score > highScore)
        {
            highScore = score;

            PlayerPrefs.SetInt("highScore", highScore);
        }

        if (counter0 == 55)
        {
            spawnEnemy0();
            counter0 = 0;
        }
        if (counter1 == 150)    
        {
            spawnEnemy1();
            counter1 = 0;
        }

        counter0++;
        counter1++;
        

    }
    void OnDrawGizmos() {
        if (!Application.isPlaying)
            return;
        Vector3 boundSize = new Vector3(camWidth * 2, camHeight * 2, 0.1f);
        Gizmos.DrawWireCube(Vector3.zero, boundSize);


    }
    public void playerDeath() {

    playerState--;

    if (playerState == 0)
      gameObject.GetComponent<restart>().RestartScene();

    }

    public void addScore(int amt) {

        score = score + amt;

    }

    public int getScore() {

        return score;
    }

    public int getHighScore() {

        return PlayerPrefs.GetInt("highScore");

    }


    public void starUpgrade(int i) {

        shield = GameObject.Find("Shield"+i.ToString());
        if (!shield.GetComponent<shield>().ifStar())
            shield.GetComponent<shield>().starShield();
        else
            Debug.Log("Failed");

    }

}
