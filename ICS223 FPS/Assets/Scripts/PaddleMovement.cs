using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleMovement : MonoBehaviour
{
    [SerializeField]
    private bool isRight = true;
    private float yMovement = 0f;
    [SerializeField]
    private Rigidbody rb;
    private float speed = 13f;
    private float yMax = 4;
    private float yMin = -4;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isRight)
        {
            yMovement = Input.GetAxis("VerticalP2");
        } else
        {
            yMovement = Input.GetAxis("VerticalP1");
        }
    }

    private void FixedUpdate()
    {
        //yMovement = Mathf.Clamp(yMovement, yMin, yMax);
        Vector3 move = new Vector3(0, yMovement, 0) * Time.deltaTime * speed;
        Vector3 newPos = transform.position + move;
        newPos.y = Mathf.Clamp(newPos.y, yMin, yMax);

        rb.MovePosition(newPos);
    }
}
