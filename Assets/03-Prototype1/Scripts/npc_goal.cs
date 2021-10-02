using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class npc_goal : MonoBehaviour
{

    public float move_speed;
    public float move_time;
    public Vector3 target_pos;
    public ui ui_game;

    // Start is called before the first frame update
    void Start()
    {
        float x = UnityEngine.Random.Range(-2, 2);

        target_pos = new Vector3(3.1f - x, 1, -6.5f);
    }

    // Update is called once per frame
    void Update()
    {

        switch (ui_game.level)
        {
            case 1:
                move_speed = 3;
                break;
            case 2:
                move_speed = 5;
                break;
            case 3:
                move_speed = 7;
                break;
            case 4:
                move_speed = 8;
                break;
            case 5:
                move_speed = 10;
                break;


        }

      
        

       float dis =Vector3.Distance(transform.position, target_pos);

        

        if (dis <= 0.1f)
        {
          float x = UnityEngine.Random.Range(-2,2);

            target_pos = new Vector3(3.1f-x,1,-6.5f);
         
 

        }
        else
        {

            Vector3 normal_pos = (target_pos - transform.position).normalized;

            transform.position += normal_pos * Time.deltaTime*move_speed;

        }

      


        
    }






    private void OnTriggerEnter(Collider other)
    {
       
        if (other.gameObject.name.Equals("football(Clone)"))
        {
            Time.timeScale = 0;
            ui_game.iswin = false;
            ui_game.losego.SetActive(true);
            Destroy(other.gameObject);
        }


    }

}
