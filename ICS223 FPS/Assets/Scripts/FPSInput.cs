using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSInput : MonoBehaviour
{
    private float speed = 9.0f;
    private float gravity = -9.8f;
    [SerializeField] private CharacterController charController;
    private float movementX;
    private float movementY;
    // Start is called before the first frame update
    void Start()
    {
        charController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        float deltaX = Input.GetAxis("Horizontal");
        float deltaZ = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(deltaX, 0, deltaZ);

        movement = Vector3.ClampMagnitude(movement, 1.0f);

        movement.y = gravity;

        movement *= speed;

        movement *= Time.deltaTime;

        movement = transform.TransformDirection(movement);

        charController.Move(movement);

        //movementX = Input.GetAxis("Horizontal");
        //movementY = Input.GetAxis("Vertical");
        //Vector3 movement = new Vector3(movementX, 0.0f, movementY);
        //transform.Translate(new Vector3(movementX,0.0f ,movementY ) * Time.deltaTime * speed);
    }
}
