using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{

    public float speed = 125f;

    // Start is called before the first frame update
    void Start()
    {
        respawn();
    }


    public  void respawn()
    {
        transform.position = Vector3.zero;
        GetComponent<Rigidbody2D>().velocity = Random.insideUnitCircle.normalized * speed;
        


    } 

    // Update is called once per frame
    void Update()
    {
        
    }
}
