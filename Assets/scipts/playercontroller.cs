using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontroller : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
public float speed = 20;
private float turnSpeed = 45;
private float HorizontalInput;
private float ForwardInput;
    // Update is called once per frame
    void Update()
    {
        HorizontalInput = Input.GetAxis("Horizontal");
        ForwardInput = Input.GetAxis("Vertical");
         // Move the vehicle forward
         transform.Translate(Vector3.forward * Time.deltaTime * speed * ForwardInput);
         transform.Rotate( Vector3.up, turnSpeed * HorizontalInput * Time.deltaTime);
    }
}