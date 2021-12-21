using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Controller : MonoBehaviour
{
    public int rotation_ID;
    public float rotation_speed = 5.0f;
    private int newRotation;
    private Vector3 currentRotation;
    public bool isRotatable;
    float wait = 0;

    // Start is called before the first frame update
    void Start()
    {
        rotation_ID = 0;
        Debug.Log(rotation_ID);
        currentRotation = transform.eulerAngles;
        isRotatable = true;
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E) && isRotatable) // Rotate to right
        {
            // Increase rotation ID
            wait = 1f;
            rotation_ID++;
            if (rotation_ID > 3)
                rotation_ID = 0;
            Debug.Log(rotation_ID);
            newRotation = (int)currentRotation.y + 90;
            //transform.Rotate(rotationToAdd * Time.deltaTime, Space.World);
            
        }

        if(Input.GetKeyDown(KeyCode.Q) && isRotatable)     // Rotate to Left
        {
            // Decrease Rotation ID
            wait = 1f;
            rotation_ID--;
            if (rotation_ID < 0)
                rotation_ID = 3;
            Debug.Log(rotation_ID);
            newRotation = (int)currentRotation.y - 90;
            //transform.Rotate(-rotationToAdd * Time.deltaTime, Space.World);            
        }
        if (wait > 0)
        {
            wait -= Time.deltaTime;
            isRotatable = false;
        }
        else
        {
            isRotatable = true;
            wait = 0;
        }

            currentRotation.y = Mathf.MoveTowards(currentRotation.y, newRotation, rotation_speed * Time.deltaTime);
        transform.eulerAngles = currentRotation;
        
    }

    /*
    // Update is called once per frame
    void RotateWorld()
    {
        if (rotation_ID == 0) // Rotation y = 0
        {
            
        }
        else if (rotation_ID == 1) // Rotation y = -90
        {

        }
        else if (rotation_ID == 2) // Rotation y = -180
        {

        }
        else if (rotation_ID == 3) // Rotation y = -180
        {

        }*/

}
