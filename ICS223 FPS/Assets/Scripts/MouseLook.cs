using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    public float sensitivityHoriz = 9.0f;
    public float sensitivityVert = 9.0f;
    public float minVert = -45.0f;
    public float maxVert = 45.0f;
    public float rotationX = 0.0f;

    public enum RotationAxes
    {
        MouseXAndY,
        MouseX,
        MouseY
    }
    public RotationAxes axes = RotationAxes.MouseXAndY;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (axes == RotationAxes.MouseX)
        {
            transform.Rotate(Vector3.up * Input.GetAxis("Mouse X") * sensitivityHoriz);
        } else if (axes == RotationAxes.MouseY)
        {
            rotationX -= Input.GetAxis("Mouse Y") * sensitivityVert;
            rotationX = Mathf.Clamp(rotationX, minVert, maxVert);
            transform.localEulerAngles = new Vector3(rotationX, 0, 0);
        } else
        {
            rotationX -= Input.GetAxis("Mouse Y") * sensitivityVert;
            rotationX = Mathf.Clamp(rotationX, minVert, maxVert);
            float deltaHoriz = Input.GetAxis("Mouse X") * sensitivityHoriz;
            float rotationY = transform.localEulerAngles.y + deltaHoriz;
            transform.localEulerAngles = new Vector3(rotationX, rotationY, 0);

        }
    }
}
