using System.Collections;
using System.Collections.Generic;
using Assets.Scripts;
using Assets.Scripts.CommandPattern;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using Time = UnityEngine.Time;

public class EndGame : MonoBehaviour
{
    public GameObject GameOver;

    void Start()
    {
        GameOver.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            SceneManager.LoadScene("Game");
            Time.timeScale = 1;
            GameOver.SetActive(false);
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        Time.timeScale = 0;
        GameOver.SetActive(true);
    }
}
