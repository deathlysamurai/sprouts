using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

[CreateAssetMenu(fileName = "InputController", menuName = "Input/Input Controller")]

public class InputController : ScriptableObject, InputManager.IDotActions
{
    InputManager inputManager;

	public event UnityAction<Vector2> ClickEvent = delegate { };

	private void OnEnable()
	{
		if (inputManager == null)
		{
			inputManager = new InputManager();

			inputManager.Dot.SetCallbacks(this);
		}

		inputManager.Enable();
	}

    private void OnDisable()
    {
		inputManager.Disable();
    }

	public void OnClick(InputAction.CallbackContext ctx)
    {
		if (ctx.started)
			ClickEvent.Invoke(Mouse.current.position.ReadValue());
    }
}
