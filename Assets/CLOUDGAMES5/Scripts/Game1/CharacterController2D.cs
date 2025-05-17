using UnityEngine;
using UnityEngine.InputSystem;

public class CharacterController2D : MonoBehaviour
{
    private Rigidbody2D myRigidbody2D;
    private Vector2 movementInput;
    private float moveSpeed = 5f;

    private void Awake()
    {
        myRigidbody2D = GetComponent<Rigidbody2D>();
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        movementInput = context.ReadValue<Vector2>();
    }

    private void FixedUpdate()
    {
        myRigidbody2D.velocity = movementInput * moveSpeed;
    }
}