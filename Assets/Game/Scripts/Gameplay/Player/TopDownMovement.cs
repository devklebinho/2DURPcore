using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class TopDownMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    private Vector2 moveInput;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    public void Move(InputAction.CallbackContext value)
    {
        moveInput = value.ReadValue<Vector2>();
        Debug.Log($"x: {moveInput.x}, y: {moveInput.y}");   
    }

    public void Jump(InputAction.CallbackContext value)
    {
        Debug.Log("Jump");
    }

    private void FixedUpdate()
    {
        rb.AddForce(new Vector2(moveInput.x, moveInput.y) * Time.fixedDeltaTime *300);
    }
}
