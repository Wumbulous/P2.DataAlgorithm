using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetMenuBehaviour : MonoBehaviour
{
    public float movementSpeed = 10f; //Controlls speed that targets bob at

    public float amplitude = 0.1f; //Controlls offset of sine movement

    private Vector3 startPos; //Stores beginning position of object

    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position; //Gets position of object on game start
        
    }

    // Update is called once per frame
    void Update()
    {
       

        float verticalMovement = Mathf.Sin(Time.time * movementSpeed) * amplitude; //Calculates sine movement according to movement speed and amplitude offset over time

        Vector3 newPos = startPos + Vector3.up * verticalMovement; //Applies vertical movement to objects up vector from starting position
        transform.position = newPos; //Applies movement to 
        
    }
    
}
