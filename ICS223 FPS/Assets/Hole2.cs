using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hole2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Ball")
        {
            Destroy(col.gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
