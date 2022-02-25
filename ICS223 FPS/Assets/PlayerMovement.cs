using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerMovement : MonoBehaviour
{
    public float speed;
    private Rigidbody rbody;
    private float movementX;
    private float movementY;

    // Start is called before the first frame update
    void Start()
    {
        rbody = GetComponent<Rigidbody>();
        
    }

  
    // Update is called once per frame
    void Update()
    {
         movementX = Input.GetAxis("Horizontal");
         movementY = Input.GetAxis("Vertical");

        Debug.Log(movementX);

    }
    void FixedUpdate()
    {
        Vector3 movement = new Vector3(movementX, 0.0f, movementY);
        //rbody.AddForce(movement * speed * 100 * Time.deltaTime);
        rbody.velocity = (movement * speed * 100 * Time.deltaTime);
        //Debug.Log(movement);
    }
}
