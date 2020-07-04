using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class paddle : MonoBehaviour
{

    public float speed = 11f;

    private float input;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        input = Input.GetAxis("Horizontal");

    }


    private void FixedUpdate()
    {
        GetComponent<Rigidbody2D>().velocity = Vector2.right * input * speed;
    }
}
