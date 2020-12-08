using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasRotator2Axis : MonoBehaviour
{
    

    // Update is called once per frame
    void Update()
    {
        Vector3 relativePosition = transform.position + Camera.main.transform.position; // get the relative direction of the canvas to the player's camera
        relativePosition.y = relativePosition.y - 20;
        Quaternion rotation = Quaternion.LookRotation(relativePosition); // create a rotation to look at the direction the player wants
        transform.rotation = rotation; // set our new rotation to our current rotation 
    }
}
