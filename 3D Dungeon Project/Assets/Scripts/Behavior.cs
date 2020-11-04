using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class Behavior : MonoBehaviour
{
    public InputActionMap moveActions;
    public InputAction lookAction;
    // Start is called before the first frame update
    void Awake()
    {

    }

    // Update is called once per frame
    void OnEnable()
    {
        lookAction.Enable();
        moveActions.Enable();
    }
}
