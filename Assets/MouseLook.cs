using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour

{
    [SerializeField] float sensitivityX = 8f;
    [SerializeField] float sensitivityY = 0.5f;
    float MouseX, MouseY;

    public void Update()
    {
        transform.Rotate(Vector3.up, MouseX * Time.deltaTime);
    }

    public void ReceiveInput (Vector2 mouseInput)
    {
        MouseX = mouseInput.x * sensitivityX;
        MouseY = mouseInput.y * sensitivityY;
    }

 


}
