// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/Input/Manager/InputManager.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @InputManager : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputManager()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputManager"",
    ""maps"": [
        {
            ""name"": ""Dot"",
            ""id"": ""54e326b3-d9a6-456e-8e90-3a35ffd4c94e"",
            ""actions"": [
                {
                    ""name"": ""Click"",
                    ""type"": ""Value"",
                    ""id"": ""f6dbd3b2-d82a-47df-a75b-5891b1b4dead"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""2285e33c-44af-4565-a3ef-987a70f8cf26"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Click"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Dot
        m_Dot = asset.FindActionMap("Dot", throwIfNotFound: true);
        m_Dot_Click = m_Dot.FindAction("Click", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    // Dot
    private readonly InputActionMap m_Dot;
    private IDotActions m_DotActionsCallbackInterface;
    private readonly InputAction m_Dot_Click;
    public struct DotActions
    {
        private @InputManager m_Wrapper;
        public DotActions(@InputManager wrapper) { m_Wrapper = wrapper; }
        public InputAction @Click => m_Wrapper.m_Dot_Click;
        public InputActionMap Get() { return m_Wrapper.m_Dot; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(DotActions set) { return set.Get(); }
        public void SetCallbacks(IDotActions instance)
        {
            if (m_Wrapper.m_DotActionsCallbackInterface != null)
            {
                @Click.started -= m_Wrapper.m_DotActionsCallbackInterface.OnClick;
                @Click.performed -= m_Wrapper.m_DotActionsCallbackInterface.OnClick;
                @Click.canceled -= m_Wrapper.m_DotActionsCallbackInterface.OnClick;
            }
            m_Wrapper.m_DotActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Click.started += instance.OnClick;
                @Click.performed += instance.OnClick;
                @Click.canceled += instance.OnClick;
            }
        }
    }
    public DotActions @Dot => new DotActions(this);
    public interface IDotActions
    {
        void OnClick(InputAction.CallbackContext context);
    }
}
