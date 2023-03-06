using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BusControl : MonoBehaviour {

    /// <summary>
    /// This is an example script for controlling the doors and signs on the bus. 
    /// You may wish to create a more specific implementation consistent with your game.
    /// </summary>

    public Animator Door1;
    public Animator Door2;
    public Animator StopSign1;
    public Animator StopSign3;
    private float speed = 20.0f;
    private float turnspeed = 1000.0f;
    private float horizontalInput;
    private float forwardInput;

    public float OpenCloseSpeed;

    private bool isOpen = false;

    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        transform.Rotate(Vector3.up, turnspeed * horizontalInput * Time.deltaTime);

        if (forwardInput == 0.0f)
            turnspeed = 0;
        else if (forwardInput > 0.0f)
            turnspeed = 45.0f;
        if (forwardInput == 0.0f)
            turnspeed = 0;
        else if (forwardInput < 0.0f)
            turnspeed = 45.0f;



    }

    public void Open(bool open = true) {
        string action = "";
        if (open)
        {
            action = "Open";
        }
        else {
            action = "Close";
        }
        Door1.SetTrigger(action);
        Door2.SetTrigger(action);
        StopSign1.SetTrigger(action);  
        StopSign3.SetTrigger(action);
        isOpen = !isOpen;
    }

    public void ToggleDoor() {
        if (isOpen)
        {
            Open(false);
        }
        else {
            Open(true);
        }
    }

}
