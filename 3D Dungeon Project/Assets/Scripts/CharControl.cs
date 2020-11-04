using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class CharControl : MonoBehaviour, DungeonProject.IPlayerActions
{
    DungeonProject controls;

    public void OnEnable()
    {
        if (controls == null)
        {
        controls = new DungeonProject();
        controls.Player.SetCallbacks(this);
        }
        controls.Player.Enable();
    }

    public void OnDisable()
    {
        controls.Player.Disable();
    }

    public void OnUse(InputAction.CallbackContext context)
    {

    }

    public void OnMove(InputAction.CallbackContext context)
    {

    }

    public void OnFire(InputAction.CallbackContext context)
    {
        
    }

    public void OnLook(InputAction.CallbackContext context)
    {
        
    }

}
