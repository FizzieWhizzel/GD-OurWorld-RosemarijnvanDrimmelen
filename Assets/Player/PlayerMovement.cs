using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += -transform.right * Time.deltaTime * 5;
            
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.position += transform.right * Time.deltaTime * 5;
            
        }

        if (Input.GetKey(KeyCode.W))
        {
            transform.position += transform.forward * Time.deltaTime * 5;
            
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.position += -transform.forward * Time.deltaTime * 5;
            
        }

        float mouseXmovement = Input.GetAxis("Mouse X");
        transform.Rotate(0,mouseXmovement * 5,0);

       
        if (Input.GetKey(KeyCode.Space))
        {
            transform.position += transform.up * Time.deltaTime * 7;
        }
    }

   
}
