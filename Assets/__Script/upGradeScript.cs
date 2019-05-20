using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class upGradeScript : powerUp{

    // Use this for initialization

    override public void setType(string name) {

    int i;
    if (name == "_Hero")
      i = 1;
    else
      i = 2;
        powerUpType = 1;
        Debug.Log("Type Set");
        manager.GetComponent<gunUpGrades>().upgrade(i);
    }


}
