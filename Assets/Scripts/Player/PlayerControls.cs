using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerControls : MonoBehaviour
{
    public float moveSpeed = 5f;

    public InputActionAsset inputActions;

    private InputAction moveAction;

    private Vector2 moveInput;

    private void OnEnable()
    {
        // Find the action inside the asset
        var actionMap = inputActions.FindActionMap("Player");
        moveAction = actionMap.FindAction("Move");

        moveAction.Enable();

        // Subscribe to performed/canceled events
        moveAction.performed += ctx => moveInput = ctx.ReadValue<Vector2>();
        moveAction.canceled += ctx => moveInput = Vector2.zero;
    }

    private void OnDisable()
    {
        moveAction.Disable();
    }

    private void Update()
    {
        Vector3 move = new Vector3(moveInput.x, moveInput.y, 0);
        transform.position += move * moveSpeed * Time.deltaTime;
    }

}
