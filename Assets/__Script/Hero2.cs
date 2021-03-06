using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero2 : MonoBehaviour
{
  public float speed = 30f;
  public float roll = -45f;
  public float pitch = 30f;
  public Camera camera;
  public GameObject child;

  public GameObject pickuppf;
  GameObject pickup;
  public GameObject pickuppf1;
  GameObject pickup1;
  public GameObject gun;
  weapon weapon;
  int weaponState;


  public enum WeaponType { Simple, Blaster, Upgraded };


  // Use this for initialization
  void Start()
  {

    GameObject boundary;
    weaponState = (int)WeaponType.Simple;

    weapon = gun.GetComponent<weapon>().getWeapon();
    weapon.vod = weapon.shootSimple;


  }

  // Update is called once per frame
  void Update()
  {

    //if (Input.GetKey("j"))
    //{
    //    pickup = Instantiate(pickuppf, gameObject.transform.position + new Vector3(0,30,0), Quaternion.identity);

    //}
    //if (Input.GetKey("k"))
    //{
    //    pickup1 = Instantiate(pickuppf1, gameObject.transform.position + new Vector3(0, 30, 0), Quaternion.identity);

    //}
    //if (Input.GetKey("p"))
    //{

    //    camera.GetComponent<Main>().addScore(50);

    //}
    


    if (Input.GetKeyDown("h")) {
      if (weaponState == 0) {
        weaponState = (int)WeaponType.Blaster;
        weapon.vod = weapon.shootBlaster;
        GameObject.Find("_Hero2").GetComponent<Hero2>().upgradeBlasters(false);
      }
      else if (weaponState == 1)
      {
        weaponState = (int)WeaponType.Upgraded;
        weapon.vod = weapon.shootUpgraded;
        GameObject.Find("_Hero2").GetComponent<Hero2>().upgradeBlasters(true);




      }
      else if (weaponState == 2)
      {
        weaponState = (int)WeaponType.Simple;
        weapon.vod = weapon.shootSimple;
        GameObject.Find("_Hero2").GetComponent<Hero2>().upgradeBlasters(false);

      }

    }
    if (Input.GetKeyDown(","))
    {
      weapon.vod();
    }

    if (gun != null)
      if (Input.GetKey("."))
      {
        gun.GetComponent<weapon>().ultmate();
      }

    float y = Input.GetAxis("P2_Vertical");
    float x = Input.GetAxis("P2_Horizontal");

    Vector3 pos = transform.position;

    transform.rotation = Quaternion.Euler(y * pitch, x * roll, 0);

    float xBound = camera.orthographicSize * camera.aspect;
    float yBound = camera.orthographicSize;

    bool stopx = (transform.position.x <= (-1 * xBound) + 2.12f) && (x <= 0)
                || (transform.position.x >= xBound - 2.12f) && (x >= 0);
    bool stopy = (transform.position.y >= yBound - 2.42f) && (y >= 0)
                || (transform.position.y <= (-1 * yBound) + 2.42f) && (y <= 0);
    if (stopx)
    {

      pos.x += (x * -1) * speed * Time.deltaTime;

    }
    if (stopy)
    {

      pos.y += (y * -1) * speed * Time.deltaTime;

    }
    pos.x += x * speed * Time.deltaTime;
    pos.y += y * speed * Time.deltaTime;



    transform.position = pos;

  }

  public void upgradeBlasters(bool upgraded)
  {

    if (upgraded)
      child.GetComponent<Renderer>().material.color = new Color(1, 0, 0);

    if (!upgraded)
      child.GetComponent<Renderer>().material.color = new Color(1, 1, 1);



  }


}
