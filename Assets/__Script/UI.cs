using UnityEngine;
using System.Collections;

public class UI : MonoBehaviour
{
    float deltaTime = 0.0f;

    public GameObject player1;
    public GameObject player2;


    public GameObject weapon1;
    public GameObject weapon2;

    int health1;
    int ult1;
    int nuke1;
    int health2;
    int ult2;
    int nuke2;
    int score = 0;
    int highScore;

    void Update()
    {

        deltaTime += (Time.unscaledDeltaTime - deltaTime) * 0.1f;
        if(player1 != null)
        health1 = GameObject.Find("Shield1").GetComponent<shield>().getHealth();
        if (player2 != null)
        health2 = GameObject.Find("Shield2").GetComponent<shield>().getHealth();
    if (player1 == null)
            health1 = 0;
        if (player2 == null)
            health2 = 0;
    score = gameObject.GetComponent<Main>().getScore();
        highScore = gameObject.GetComponent<Main>().getHighScore();
        if (player1 == null)
        {
            ult1 = 0;
            nuke1 = 0;
        }
        else
        {
            ult1 = weapon1.GetComponent<weapon>().ultiAmmo();
            nuke1 = weapon1.GetComponent<weapon>().nukeAmmo();
        }
        if (player2 == null)
        {
          ult2 = 0;
          nuke2 = 0;
        }
        else
        {
          ult2 = weapon2.GetComponent<weapon>().ultiAmmo();
          nuke2 = weapon2.GetComponent<weapon>().nukeAmmo();
        }
  }

    void OnGUI()
    {
        int w = Screen.width, h = Screen.height;

        GUIStyle style = new GUIStyle();
        GUIStyle style2 = new GUIStyle();
        GUIStyle style3 = new GUIStyle();
        GUIStyle style4 = new GUIStyle();
        GUIStyle style5 = new GUIStyle();
        GUIStyle style6 = new GUIStyle();
        GUIStyle style7 = new GUIStyle();
        GUIStyle style8 = new GUIStyle();
        GUIStyle style9 = new GUIStyle();

    Rect rect = new Rect(0, 30, w, h * 2 / 100);
        Rect rect1 = new Rect(0, 0, w, h * 2 / 100);
        Rect rect2 = new Rect(0, 0, w, h * 2 / 100);
        Rect nukeRect = new Rect(0, h - 20, w, h * 2 / 100);
        Rect ultRect = new Rect(0, h - 60, w, h * 2 / 100);

        //style.alignment = TextAnchor.LowerLeft;
        //style.fontSize = h * 2 / 100;
        //style.normal.textColor = new Color(1.0f, 1.0f, 1f, 1.0f);


        style2.alignment = TextAnchor.UpperLeft;
        style2.fontSize = h * 2 / 50;
        style2.normal.textColor = new Color(1.0f, 1.0f, 1f, 1.0f);

        style3.alignment = TextAnchor.UpperCenter;
        style3.fontSize = h * 2 / 50;
        style3.normal.textColor = new Color(1.0f, 1.0f, 1f, 1.0f);

        style4.alignment = TextAnchor.UpperCenter;
        style4.fontSize = h * 2 / 50;
        style4.normal.textColor = new Color(1.0f, 1.0f, 1f, 1.0f);

        style5.alignment = TextAnchor.UpperLeft;
        style5.fontSize = h * 2 / 50;
        style5.normal.textColor = new Color(1.0f, 1.0f, 1f, 1.0f);

        style6.alignment = TextAnchor.UpperLeft;
        style6.fontSize = h * 2 / 50;
        style6.normal.textColor = new Color(1.0f, 1.0f, 1f, 1.0f);

        style7.alignment = TextAnchor.UpperRight;
        style7.fontSize = h * 2 / 50;
        style7.normal.textColor = new Color(1.0f, 1.0f, 1f, 1.0f);

        style8.alignment = TextAnchor.UpperRight;
        style8.fontSize = h * 2 / 50;
        style8.normal.textColor = new Color(1.0f, 1.0f, 1f, 1.0f);

        style9.alignment = TextAnchor.UpperRight;
        style9.fontSize = h * 2 / 50;
        style9.normal.textColor = new Color(1.0f, 1.0f, 1f, 1.0f);


    float msec = deltaTime * 1000.0f;
        float fps = 1.0f / deltaTime;

        string frames = string.Format("{0:0.0} ms ({1:0.} fps)", msec, fps);
        string player1Health = ("Player 1 Health: " + health1.ToString());
        string player2Health = ("Player 2 Health: " + health2.ToString());
        string scoreText = ("Score: "+ score.ToString());
        string hScore = ("High Score: " + highScore.ToString());
        string ult1String = ("Player 1 Ultimate Ammo: " + ult1.ToString());
        string nuke1String = ("Player 1 Nuke Ammo: " + nuke1.ToString());
        string ult2String = ("Player 2 Ultimate Ammo: " + ult2.ToString());
        string nuke2String = ("Player 2 Nuke Ammo: " + nuke2.ToString());

    //GUI.Label(frames, text, style);
        GUI.Label(rect2, player1Health, style2);
        GUI.Label(rect2, player2Health, style7);
        GUI.Label(rect, scoreText, style3);
        GUI.Label(rect1, hScore, style4);
        GUI.Label(ultRect, ult1String, style5);
        GUI.Label(nukeRect, nuke1String, style6);
        GUI.Label(ultRect, ult2String, style8);
        GUI.Label(nukeRect, nuke2String, style9);
  }

 

}
