using System.Collections;
using System.Collections.Generic;
using Assets.Scripts;
using Assets.Scripts.CommandPattern;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Ball : MonoBehaviour
{
    public float speed = 5f;

    void Start()
    {
        float x = (Random.Range(0, 2) == 0) ? -1 : 1; //init movement vector path
        float y = (Random.Range(0, 2) == 0) ? -1 : 1;

        GetComponent<Rigidbody2D>().velocity = new Vector3(x, y, 0);
        GetComponent<Rigidbody2D>().velocity *= speed; //init speed
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        Commands.Instance.AddCommand(new HitCommand(collision.gameObject));
    }
    private void OnCollisionEnter(Collision collision)
    {
        Commands.Instance.AddCommand(new HitCommand(collision.gameObject));
    }
}
