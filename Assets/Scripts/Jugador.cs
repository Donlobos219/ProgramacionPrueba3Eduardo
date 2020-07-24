using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-6f * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(6f * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(0, -6f * Time.deltaTime, 0);
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(0, 6f * Time.deltaTime, 0);
        }


    }

}
