using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;      
public class TesteInput : MonoBehaviour
{
    public void ShortJump(InputAction.CallbackContext action)
    {
        if (action.performed)
            Debug.Log("Short Jump");
    }

    public void LongJump(InputAction.CallbackContext action)
    {
        if (action.performed)
            Debug.Log("Long Jump");
    }
}
