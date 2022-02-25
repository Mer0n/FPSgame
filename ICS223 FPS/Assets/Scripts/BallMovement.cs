using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    [SerializeField]
    private Rigidbody rb;
    float speed = 5f;
  

        
    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    public void Launch(Vector3 move)
    {
        rb.AddForce(move * speed * 100);  
    }
    public void Reset()
    {
        rb.velocity = Vector3.zero;
        transform.position = Vector3.zero;
        //Launch(GetRandomBallDirection());
    }
    
   

    // Update is called once per frame
    void Update()
    {
       
    }
}
