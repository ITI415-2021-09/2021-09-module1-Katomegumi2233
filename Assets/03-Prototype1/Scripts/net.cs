using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class net : MonoBehaviour
{
    public ui ui_game;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject.name.Equals("football(Clone)"))
        {
            Time.timeScale = 0;
            ui_game.iswin = true;
            ui_game.wingo.SetActive(true);
            
            Destroy(other.gameObject);
        }


    }
}
