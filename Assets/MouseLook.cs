using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class MouseLook : MonoBehaviour

{
    [SerializeField] float sensitivityX = 3f;
    [SerializeField] float sensitivityY = 3f;
    float MouseX, MouseY;

    [SerializeField] Transform playerCamera;
    [SerializeField] float xClamp = 85f;
    float xRotation = 0f;

    public void Update()
    {
        transform.Rotate(Vector3.up, MouseX * Time.deltaTime);

        xRotation -= MouseY;
        xRotation = Mathf.Clamp(xRotation, -xClamp, xClamp);
        Vector3 targetRotation = transform.eulerAngles;
        targetRotation.x = xRotation;
        playerCamera.eulerAngles = targetRotation;
            
    }

    public void ReceiveInput (Vector2 mouseInput)
    {
        MouseX = mouseInput.x * sensitivityX;
        MouseY = mouseInput.y * sensitivityY;
    }

 


}
