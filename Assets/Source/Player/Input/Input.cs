//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.1.0
//     from Assets/Source/Player/Input/Input.inputactions
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

public partial class @Input : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @Input()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Input"",
    ""maps"": [
        {
            ""name"": ""CityViewCameraController"",
            ""id"": ""a6141ff3-c969-4e17-92a2-67512b3b54b5"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Button"",
                    ""id"": ""6bec2a50-f50d-4951-8850-ce4b581d4756"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""WorldInteraction"",
                    ""type"": ""Button"",
                    ""id"": ""8a44a3b8-a69f-4d79-a461-a38b39f17281"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""HUDInteraction"",
                    ""type"": ""Button"",
                    ""id"": ""a9481ce6-e266-4c66-b634-229b25df63d5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""Move"",
                    ""id"": ""c5796512-72dc-4187-bb88-9b8c0db5b5e4"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""a28aaa11-036a-475a-beed-ca1e9846ecee"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""91436eed-4dcd-4161-908e-812fbe2432ad"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Strafe"",
                    ""id"": ""642f7d74-dfd4-44f1-9ee9-ec530f42a804"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""410a99a2-7b13-4506-b895-51587043c3dd"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""6e48dcf5-432e-41ef-8be5-96113b651d08"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // CityViewCameraController
        m_CityViewCameraController = asset.FindActionMap("CityViewCameraController", throwIfNotFound: true);
        m_CityViewCameraController_Movement = m_CityViewCameraController.FindAction("Movement", throwIfNotFound: true);
        m_CityViewCameraController_WorldInteraction = m_CityViewCameraController.FindAction("WorldInteraction", throwIfNotFound: true);
        m_CityViewCameraController_HUDInteraction = m_CityViewCameraController.FindAction("HUDInteraction", throwIfNotFound: true);
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

    // CityViewCameraController
    private readonly InputActionMap m_CityViewCameraController;
    private ICityViewCameraControllerActions m_CityViewCameraControllerActionsCallbackInterface;
    private readonly InputAction m_CityViewCameraController_Movement;
    private readonly InputAction m_CityViewCameraController_WorldInteraction;
    private readonly InputAction m_CityViewCameraController_HUDInteraction;
    public struct CityViewCameraControllerActions
    {
        private @Input m_Wrapper;
        public CityViewCameraControllerActions(@Input wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_CityViewCameraController_Movement;
        public InputAction @WorldInteraction => m_Wrapper.m_CityViewCameraController_WorldInteraction;
        public InputAction @HUDInteraction => m_Wrapper.m_CityViewCameraController_HUDInteraction;
        public InputActionMap Get() { return m_Wrapper.m_CityViewCameraController; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(CityViewCameraControllerActions set) { return set.Get(); }
        public void SetCallbacks(ICityViewCameraControllerActions instance)
        {
            if (m_Wrapper.m_CityViewCameraControllerActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_CityViewCameraControllerActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_CityViewCameraControllerActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_CityViewCameraControllerActionsCallbackInterface.OnMovement;
                @WorldInteraction.started -= m_Wrapper.m_CityViewCameraControllerActionsCallbackInterface.OnWorldInteraction;
                @WorldInteraction.performed -= m_Wrapper.m_CityViewCameraControllerActionsCallbackInterface.OnWorldInteraction;
                @WorldInteraction.canceled -= m_Wrapper.m_CityViewCameraControllerActionsCallbackInterface.OnWorldInteraction;
                @HUDInteraction.started -= m_Wrapper.m_CityViewCameraControllerActionsCallbackInterface.OnHUDInteraction;
                @HUDInteraction.performed -= m_Wrapper.m_CityViewCameraControllerActionsCallbackInterface.OnHUDInteraction;
                @HUDInteraction.canceled -= m_Wrapper.m_CityViewCameraControllerActionsCallbackInterface.OnHUDInteraction;
            }
            m_Wrapper.m_CityViewCameraControllerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @WorldInteraction.started += instance.OnWorldInteraction;
                @WorldInteraction.performed += instance.OnWorldInteraction;
                @WorldInteraction.canceled += instance.OnWorldInteraction;
                @HUDInteraction.started += instance.OnHUDInteraction;
                @HUDInteraction.performed += instance.OnHUDInteraction;
                @HUDInteraction.canceled += instance.OnHUDInteraction;
            }
        }
    }
    public CityViewCameraControllerActions @CityViewCameraController => new CityViewCameraControllerActions(this);
    public interface ICityViewCameraControllerActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnWorldInteraction(InputAction.CallbackContext context);
        void OnHUDInteraction(InputAction.CallbackContext context);
    }
}
