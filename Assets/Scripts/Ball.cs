using System.Collections;
using System.Collections.Generic;
using Assets.Scripts;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Ball : MonoBehaviour
{
    public float speed = 5f;
    public int score = 0;
    public TMP_Text ScoreUI;

    public AudioClip hitBox;
    public AudioClip endGame;
    public AudioSource audio;


    void Start()
    {
        float x = (Random.Range(0, 2) == 0) ? -1 : 1; //init movement vector path
        float y = (Random.Range(0, 2) == 0) ? -1 : 1;

        GetComponent<Rigidbody>().velocity = new Vector3(x, y, 0);
        GetComponent<Rigidbody>().velocity *= speed; //init speed

        Locator.SetAudioFirst(new AudioService(hitBox, audio));       //ServiceLocator
        Locator.SetAudioSecond(new AudioService(endGame, audio));
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "SideWallB")   //bottom wall
        {
            EndGame();
        }
        else if (collision.gameObject.name != "Bumper" 
            && collision.gameObject.name != "SideWallR" 
            && collision.gameObject.name != "SideWallL" 
            && collision.gameObject.name != "SideWallT" )   //brick
        {
            collision.gameObject.SetActive(false);  //destroy brick
            ScoreUI.text = (++score).ToString();    //set score

            Locator.GetAudioFirst().PlaySound();
        }
    }

    private void EndGame()
    {
        Locator.GetAudioSecond().PlaySound();
        score = 0;  //lose,make new scene, play sound
        ScoreUI.text = score.ToString();
    }
}
