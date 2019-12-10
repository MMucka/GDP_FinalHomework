using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bumper : MonoBehaviour
{
    public float speed = 8.0f;

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis($"Horizontal") * speed * Time.deltaTime;
        transform.Translate(x, 0f, 0f);
    }
}
