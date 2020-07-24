using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pelota : MonoBehaviour
{
    public GameObject texto;
    public int puntos;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
        Destroy(gameObject, 5f);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == ("PUNTO"))
        {
            Instantiate(texto, transform.position, Quaternion.identity);
            Destroy(gameObject);
            Puntaje.scoreValue += puntos;

        }
    }
}