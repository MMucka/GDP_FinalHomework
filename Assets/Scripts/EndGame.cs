using System.Collections;
using System.Collections.Generic;
using Assets.Scripts;
using Assets.Scripts.CommandPattern;
using UnityEngine;

public class EndGame : MonoBehaviour
{
    // Start is called before the first frame update
    void OnCollisionEnter2D(Collision2D collision)
    {
        Commands.Instance.AddCommand(new EndGameCommand(this.gameObject));
    }
}
