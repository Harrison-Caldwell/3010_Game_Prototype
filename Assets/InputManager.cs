using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{

    [SerializeField] Movement movement;

    PlayerControls controls;
    PlayerControls.GroundMovementActions groundMovement;

    Vector2 horizontalInput;
    Vector2 mouseInput;

    float MouseX, MouseY;
    float SensitivityX;
    float SensitivityY;

    private void Awake()
    {
        controls = new PlayerControls();
        groundMovement = controls.GroundMovement;

        groundMovement.HorizontalMovement.performed += ctx => horizontalInput = ctx.ReadValue < Vector2> ();
        groundMovement.Jump.performed += _ => movement.OnJumpPressed();
        groundMovement.MouseX.performed += ctx => mouseInput.x = ctx.ReadValue<float>();
        groundMovement.MouseY.performed += ctx => mouseInput.y = ctx.ReadValue<float>();
        

    }

    public void RecieveInput(Vector2 mouseInput)
    {
        MouseX = mouseInput.x * SensitivityX;
        MouseY = mouseInput.y * SensitivityY;
    }

    private void Update()
    {
        movement.ReceiveInput(horizontalInput);
        transform.Rotate(Vector3.up, MouseX * Time.deltaTime);
    }

    private void OnEnable()
    {
        controls.Enable();
    }

    private void OnDestroy()
    {
        controls.Disable();
    }



}
