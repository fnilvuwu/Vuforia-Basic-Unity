using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public float rotateSpeed = 50f; // Rotation speed, default 50 units per second.
    private bool rotateStatus = false;

    void Update()
    {
        if (rotateStatus)
        {
            // Rotate around the Y-axis
            transform.Rotate(0, rotateSpeed * Time.deltaTime, 0, Space.World);
        }
    }

    // Method to toggle rotation on or off
    public void ToggleRotate()
    {
        rotateStatus = !rotateStatus;
    }
}
