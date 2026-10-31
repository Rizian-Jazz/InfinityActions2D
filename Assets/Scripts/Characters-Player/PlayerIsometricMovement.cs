using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerIsometricMovement : PlayerController
{
    public float moveSpeed = 15f;
    
    Vector2 moveInput, playerVelocity, movIsometrico;
    
    public override void FixedUpdate()
    {
        playerVelocity = movIsometrico * moveSpeed;
        rb.linearVelocity = playerVelocity * moveSpeed * Time.fixedDeltaTime; 
    }
    public void onMove(InputAction.CallbackContext context)
    {
        moveInput = new Vector2(context.ReadValue<Vector2>().x, context.ReadValue<Vector2>().y);
        Vector2 inputLimitado = Vector2.ClampMagnitude(moveInput, 1f);
        movIsometrico.x = inputLimitado.x - inputLimitado.y;
        movIsometrico.y = (inputLimitado.x + inputLimitado.y) * 0.5f;
    }

}


