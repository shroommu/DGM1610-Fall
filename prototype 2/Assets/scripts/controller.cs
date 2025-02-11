﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controller : MonoBehaviour
{

    public float horizontalInput;
    public float speed = 10.0f;
    public float xRange = 10.0f;
    public GameObject projectileprefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x < -xRange)
        {
            transform.position = new Vector3 (-10,transform.position.y, transform.position.z);
        }
        if(transform.position.x > xRange)
        {
        transform.position = new Vector3 (10,transform.position.y, transform.position.z);
        }
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right*horizontalInput * Time.deltaTime * speed);

        if(Input.GetKeyDown(KeyCode.Space)){

            Instantiate(projectileprefab, transform.position, projectileprefab.transform.rotation);

            //launch food at animals
        }
    }
}
