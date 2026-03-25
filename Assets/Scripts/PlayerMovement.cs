using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    private Vector2 _input;
    public void move(InputAction.CallbackContext context)
    {
        _input = context.ReadValue<Vector2>();
        Debug.Log(_input);
    }
}
