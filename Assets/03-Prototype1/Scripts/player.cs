using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class player : MonoBehaviour
{


    public float time;
    public bool flage;
    public float football_speed;


    public GameObject Bullet;

    private void Awake()
    {
        football_speed = -300;
        time = 1.0f;
        flage = false;




    }


    private void Update()
    {
        if (flage)
        {
            if (!EventSystem.current.IsPointerOverGameObject())
            {
                if (Input.GetMouseButton(0))
                {
                    flage = false;
                    Vector3 pos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 3));
                    GameObject go = GameObject.Instantiate<GameObject>(Bullet,
                      new Vector3(pos.x, 0.48f, pos.z),
                           Quaternion.identity);


                    go.GetComponent<Rigidbody>().AddForce(Vector3.forward * football_speed);




                }

            }

        }
        else
        {
            if (time <= 0)
            {
                time = 1;
                flage = true;
            }
            else
            {
                time -= Time.deltaTime;
            }

        }

       

    }





}
