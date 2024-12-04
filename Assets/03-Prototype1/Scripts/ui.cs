using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class ui : MonoBehaviour
{
    public Button submit_lose_btn;
    public Button submit_win_btn;
    public GameObject losego;
    public GameObject wingo;
    public bool iswin;
    public int level;
    

    // Start is called before the first frame update
    void Start()
    {
        level = 1;
        iswin = false;
        submit_win_btn.onClick.AddListener(submit_logic);
        submit_lose_btn.onClick.AddListener(submit_logic);
    }

    private void submit_logic()
    {
        if (iswin)
        {
            Time.timeScale = 1;
            wingo.SetActive(false);
            level += 1;
            if (level >= 5)
            {
                level = 5;
            }
        }
        else
        {
            Time.timeScale = 1;
            SceneManager.LoadScene(3);
            losego.SetActive(false);
        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
