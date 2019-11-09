using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameover : MonoBehaviour
{

    public static bool isPlayerDead = false;
    private Text gameOver;

    void Start()
    {
        gameOver = GetComponent<Text>();
        gameOver.enabled = false;
    }

    void Update()
    {
        if (isPlayerDead)
        {
            Time.timeScale = 0;
            gameOver.enabled = true;
        }
    }
}