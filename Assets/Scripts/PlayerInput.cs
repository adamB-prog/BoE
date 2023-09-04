//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.3.0
//     from Assets/Scripts/PlayerInput.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @PlayerInput : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInput"",
    ""maps"": [
        {
            ""name"": ""ShipControl"",
            ""id"": ""b31248fd-8cb1-460a-968a-6fa2550250f6"",
            ""actions"": [
                {
                    ""name"": ""Fly"",
                    ""type"": ""Value"",
                    ""id"": ""fb6a40c4-e801-4ba7-9eaa-0b788423c9eb"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""RadarOnOff"",
                    ""type"": ""Button"",
                    ""id"": ""aeb9fb96-f7c9-4b58-a85c-7fa55c71a117"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Shoot"",
                    ""type"": ""Button"",
                    ""id"": ""8dfd10ad-d760-4b3b-b703-bdd8b77f153b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Acceleration"",
                    ""type"": ""Value"",
                    ""id"": ""7334a296-fd6b-4e8d-968e-37b25aa5f883"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""07c5ea48-f239-41c7-bdd8-f7dff09b56c5"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Fly"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bb144397-2294-40d4-bd20-837bd013c276"",
                    ""path"": ""<Keyboard>/tab"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RadarOnOff"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""370f6617-56c7-48bd-8e66-7919f6d05659"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""3e8e40dd-14d6-4815-bd3b-ce324690061b"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Acceleration"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""92806a0c-9f06-49e1-9efd-428faa062690"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Acceleration"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""65a6a641-ad74-43c0-8411-0ac4ee660b44"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Acceleration"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        },
        {
            ""name"": ""UIControl"",
            ""id"": ""98dca477-6be5-4c77-bdb9-e6ba6077290b"",
            ""actions"": [
                {
                    ""name"": ""Navigate"",
                    ""type"": ""Value"",
                    ""id"": ""9bc80dda-f6ff-4467-a614-e16a13223375"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Submit"",
                    ""type"": ""Button"",
                    ""id"": ""f25368f8-d566-4cc2-b49e-23a7693581c4"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Escape"",
                    ""type"": ""Button"",
                    ""id"": ""c4a07561-833d-4781-b11a-214f34e9c6b2"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""Keyboard"",
                    ""id"": ""2cd5aded-bdb2-4f8a-9716-d1b49fb2cdd2"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Navigate"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""e6ccd563-49f4-4f20-8924-25dcac536b16"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""384b5c75-41da-4b0c-9d73-96f63ba10e9c"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""54aacdec-ecc2-42e0-9832-8e397b1af593"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""f7478a3d-be33-4cca-b363-db817bca17bf"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""2976a2a7-bbe2-4bb7-b2f0-79c97d4e4f0d"",
                    ""path"": ""<Keyboard>/enter"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Submit"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0e09787a-df4f-46f6-8604-ed7d465f4339"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Escape"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // ShipControl
        m_ShipControl = asset.FindActionMap("ShipControl", throwIfNotFound: true);
        m_ShipControl_Fly = m_ShipControl.FindAction("Fly", throwIfNotFound: true);
        m_ShipControl_RadarOnOff = m_ShipControl.FindAction("RadarOnOff", throwIfNotFound: true);
        m_ShipControl_Shoot = m_ShipControl.FindAction("Shoot", throwIfNotFound: true);
        m_ShipControl_Acceleration = m_ShipControl.FindAction("Acceleration", throwIfNotFound: true);
        // UIControl
        m_UIControl = asset.FindActionMap("UIControl", throwIfNotFound: true);
        m_UIControl_Navigate = m_UIControl.FindAction("Navigate", throwIfNotFound: true);
        m_UIControl_Submit = m_UIControl.FindAction("Submit", throwIfNotFound: true);
        m_UIControl_Escape = m_UIControl.FindAction("Escape", throwIfNotFound: true);
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
    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }
    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // ShipControl
    private readonly InputActionMap m_ShipControl;
    private IShipControlActions m_ShipControlActionsCallbackInterface;
    private readonly InputAction m_ShipControl_Fly;
    private readonly InputAction m_ShipControl_RadarOnOff;
    private readonly InputAction m_ShipControl_Shoot;
    private readonly InputAction m_ShipControl_Acceleration;
    public struct ShipControlActions
    {
        private @PlayerInput m_Wrapper;
        public ShipControlActions(@PlayerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Fly => m_Wrapper.m_ShipControl_Fly;
        public InputAction @RadarOnOff => m_Wrapper.m_ShipControl_RadarOnOff;
        public InputAction @Shoot => m_Wrapper.m_ShipControl_Shoot;
        public InputAction @Acceleration => m_Wrapper.m_ShipControl_Acceleration;
        public InputActionMap Get() { return m_Wrapper.m_ShipControl; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(ShipControlActions set) { return set.Get(); }
        public void SetCallbacks(IShipControlActions instance)
        {
            if (m_Wrapper.m_ShipControlActionsCallbackInterface != null)
            {
                @Fly.started -= m_Wrapper.m_ShipControlActionsCallbackInterface.OnFly;
                @Fly.performed -= m_Wrapper.m_ShipControlActionsCallbackInterface.OnFly;
                @Fly.canceled -= m_Wrapper.m_ShipControlActionsCallbackInterface.OnFly;
                @RadarOnOff.started -= m_Wrapper.m_ShipControlActionsCallbackInterface.OnRadarOnOff;
                @RadarOnOff.performed -= m_Wrapper.m_ShipControlActionsCallbackInterface.OnRadarOnOff;
                @RadarOnOff.canceled -= m_Wrapper.m_ShipControlActionsCallbackInterface.OnRadarOnOff;
                @Shoot.started -= m_Wrapper.m_ShipControlActionsCallbackInterface.OnShoot;
                @Shoot.performed -= m_Wrapper.m_ShipControlActionsCallbackInterface.OnShoot;
                @Shoot.canceled -= m_Wrapper.m_ShipControlActionsCallbackInterface.OnShoot;
                @Acceleration.started -= m_Wrapper.m_ShipControlActionsCallbackInterface.OnAcceleration;
                @Acceleration.performed -= m_Wrapper.m_ShipControlActionsCallbackInterface.OnAcceleration;
                @Acceleration.canceled -= m_Wrapper.m_ShipControlActionsCallbackInterface.OnAcceleration;
            }
            m_Wrapper.m_ShipControlActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Fly.started += instance.OnFly;
                @Fly.performed += instance.OnFly;
                @Fly.canceled += instance.OnFly;
                @RadarOnOff.started += instance.OnRadarOnOff;
                @RadarOnOff.performed += instance.OnRadarOnOff;
                @RadarOnOff.canceled += instance.OnRadarOnOff;
                @Shoot.started += instance.OnShoot;
                @Shoot.performed += instance.OnShoot;
                @Shoot.canceled += instance.OnShoot;
                @Acceleration.started += instance.OnAcceleration;
                @Acceleration.performed += instance.OnAcceleration;
                @Acceleration.canceled += instance.OnAcceleration;
            }
        }
    }
    public ShipControlActions @ShipControl => new ShipControlActions(this);

    // UIControl
    private readonly InputActionMap m_UIControl;
    private IUIControlActions m_UIControlActionsCallbackInterface;
    private readonly InputAction m_UIControl_Navigate;
    private readonly InputAction m_UIControl_Submit;
    private readonly InputAction m_UIControl_Escape;
    public struct UIControlActions
    {
        private @PlayerInput m_Wrapper;
        public UIControlActions(@PlayerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Navigate => m_Wrapper.m_UIControl_Navigate;
        public InputAction @Submit => m_Wrapper.m_UIControl_Submit;
        public InputAction @Escape => m_Wrapper.m_UIControl_Escape;
        public InputActionMap Get() { return m_Wrapper.m_UIControl; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(UIControlActions set) { return set.Get(); }
        public void SetCallbacks(IUIControlActions instance)
        {
            if (m_Wrapper.m_UIControlActionsCallbackInterface != null)
            {
                @Navigate.started -= m_Wrapper.m_UIControlActionsCallbackInterface.OnNavigate;
                @Navigate.performed -= m_Wrapper.m_UIControlActionsCallbackInterface.OnNavigate;
                @Navigate.canceled -= m_Wrapper.m_UIControlActionsCallbackInterface.OnNavigate;
                @Submit.started -= m_Wrapper.m_UIControlActionsCallbackInterface.OnSubmit;
                @Submit.performed -= m_Wrapper.m_UIControlActionsCallbackInterface.OnSubmit;
                @Submit.canceled -= m_Wrapper.m_UIControlActionsCallbackInterface.OnSubmit;
                @Escape.started -= m_Wrapper.m_UIControlActionsCallbackInterface.OnEscape;
                @Escape.performed -= m_Wrapper.m_UIControlActionsCallbackInterface.OnEscape;
                @Escape.canceled -= m_Wrapper.m_UIControlActionsCallbackInterface.OnEscape;
            }
            m_Wrapper.m_UIControlActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Navigate.started += instance.OnNavigate;
                @Navigate.performed += instance.OnNavigate;
                @Navigate.canceled += instance.OnNavigate;
                @Submit.started += instance.OnSubmit;
                @Submit.performed += instance.OnSubmit;
                @Submit.canceled += instance.OnSubmit;
                @Escape.started += instance.OnEscape;
                @Escape.performed += instance.OnEscape;
                @Escape.canceled += instance.OnEscape;
            }
        }
    }
    public UIControlActions @UIControl => new UIControlActions(this);
    public interface IShipControlActions
    {
        void OnFly(InputAction.CallbackContext context);
        void OnRadarOnOff(InputAction.CallbackContext context);
        void OnShoot(InputAction.CallbackContext context);
        void OnAcceleration(InputAction.CallbackContext context);
    }
    public interface IUIControlActions
    {
        void OnNavigate(InputAction.CallbackContext context);
        void OnSubmit(InputAction.CallbackContext context);
        void OnEscape(InputAction.CallbackContext context);
    }
}