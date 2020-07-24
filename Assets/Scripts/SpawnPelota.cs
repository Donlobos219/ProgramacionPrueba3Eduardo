using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPelota : MonoBehaviour
{
    public Rigidbody2D pelota;
    public float spawnRate = 2f;
    public float speed = 5f;
    public bool permitirPelota;
    public Transform spawnPoint;
    // Start is called before the first frame update

    void Start()
    {
        permitirPelota = true;
        InvokeRepeating("pelota1", 1.9f, 2f);
    }

    // Update is called once per frame
    void Update()
    {

        {

        }


    }
    void pelota1()
    {
        Rigidbody2D bulletInstance;
        bulletInstance = Instantiate(pelota, spawnPoint.position, spawnPoint.rotation);
        bulletInstance.AddForce(spawnPoint.forward * -500f);
        
        
    }

}
