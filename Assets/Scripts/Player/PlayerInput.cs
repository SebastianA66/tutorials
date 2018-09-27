using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * The PlayerInput is in charge of recieving input
 * from the user and interacting with PlayerController
 */
public class PlayerInput : MonoBehaviour
{
    public PlayerController controller;
    
    // Update is called once per frame
    void Update()
    {
        // Check if Mouse Button is down
        // 0 = Left
        // 1 = Right
        // 2 = Middle
        if (Input.GetMouseButtonDown(0))
        {
            // Get ray from camera
            Ray camRay = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            // Raycast out to hit something
            if (Physics.Raycast(camRay, out hit, 1000f))
            {
                // Update the target with the point we hit
                controller.SetDestination(hit.point);
            }
        }
    }
}
