//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.2.0
//     from Assets/Scripts/Input/PlayerInputController.inputactions
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

public partial class @PlayerInputController : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInputController()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInputController"",
    ""maps"": [
        {
            ""name"": ""Suelo"",
            ""id"": ""d931b5fa-7184-4f48-8706-99f6e0654eec"",
            ""actions"": [
                {
                    ""name"": ""Mover"",
                    ""type"": ""PassThrough"",
                    ""id"": ""33032e80-1b4f-4dac-971a-12aada714d27"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Saltar"",
                    ""type"": ""PassThrough"",
                    ""id"": ""0832e2db-ab54-4d47-a9c7-e4ed0d435699"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Interactuar"",
                    ""type"": ""PassThrough"",
                    ""id"": ""d4ff4efc-a999-486f-a964-45ac99a5fb38"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Menu"",
                    ""type"": ""Button"",
                    ""id"": ""0c616f1a-79b5-4fb2-967c-d0d35cded556"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""1b03f94a-ae86-4830-9125-416a26eee932"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": ""Press(behavior=1)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Saltar"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""WASD"",
                    ""id"": ""6f3c1876-21b3-44fb-b6f5-b78b252b4e28"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Mover"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""2188fc14-f07a-425c-94f3-ed8c1f9a1229"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Mover"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""fc9c3fb5-108e-4569-b35c-08efabaa18ee"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Mover"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""2de25944-dc9b-418c-b5ee-900ba8bdb31a"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Mover"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""eb023724-f1a3-40d1-b6c6-e5db15d2fede"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Mover"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""bdae8e16-3cdd-462f-a089-eb4a049867c3"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": ""Press(behavior=1)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Interactuar"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""45be4c3c-a7dd-4a76-a135-4566ae32af99"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": ""Press(behavior=1)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Menu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""SinGravedad"",
            ""id"": ""8c54c582-45c2-4474-b273-df5747e71b9b"",
            ""actions"": [
                {
                    ""name"": ""Propulsar"",
                    ""type"": ""Button"",
                    ""id"": ""ebe277fc-998a-4a1c-8d57-5c77f4527a75"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""vertical"",
                    ""id"": ""4fac7848-edf6-4d76-a608-28bf65b1c960"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Propulsar"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""2a338c53-5174-49fe-9b53-33a37832a392"",
                    ""path"": ""<Keyboard>/shift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Propulsar"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""a3bd5123-4f08-45a3-be98-5b54ada8ae83"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Propulsar"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Suelo
        m_Suelo = asset.FindActionMap("Suelo", throwIfNotFound: true);
        m_Suelo_Mover = m_Suelo.FindAction("Mover", throwIfNotFound: true);
        m_Suelo_Saltar = m_Suelo.FindAction("Saltar", throwIfNotFound: true);
        m_Suelo_Interactuar = m_Suelo.FindAction("Interactuar", throwIfNotFound: true);
        m_Suelo_Menu = m_Suelo.FindAction("Menu", throwIfNotFound: true);
        // SinGravedad
        m_SinGravedad = asset.FindActionMap("SinGravedad", throwIfNotFound: true);
        m_SinGravedad_Propulsar = m_SinGravedad.FindAction("Propulsar", throwIfNotFound: true);
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

    // Suelo
    private readonly InputActionMap m_Suelo;
    private ISueloActions m_SueloActionsCallbackInterface;
    private readonly InputAction m_Suelo_Mover;
    private readonly InputAction m_Suelo_Saltar;
    private readonly InputAction m_Suelo_Interactuar;
    private readonly InputAction m_Suelo_Menu;
    public struct SueloActions
    {
        private @PlayerInputController m_Wrapper;
        public SueloActions(@PlayerInputController wrapper) { m_Wrapper = wrapper; }
        public InputAction @Mover => m_Wrapper.m_Suelo_Mover;
        public InputAction @Saltar => m_Wrapper.m_Suelo_Saltar;
        public InputAction @Interactuar => m_Wrapper.m_Suelo_Interactuar;
        public InputAction @Menu => m_Wrapper.m_Suelo_Menu;
        public InputActionMap Get() { return m_Wrapper.m_Suelo; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(SueloActions set) { return set.Get(); }
        public void SetCallbacks(ISueloActions instance)
        {
            if (m_Wrapper.m_SueloActionsCallbackInterface != null)
            {
                @Mover.started -= m_Wrapper.m_SueloActionsCallbackInterface.OnMover;
                @Mover.performed -= m_Wrapper.m_SueloActionsCallbackInterface.OnMover;
                @Mover.canceled -= m_Wrapper.m_SueloActionsCallbackInterface.OnMover;
                @Saltar.started -= m_Wrapper.m_SueloActionsCallbackInterface.OnSaltar;
                @Saltar.performed -= m_Wrapper.m_SueloActionsCallbackInterface.OnSaltar;
                @Saltar.canceled -= m_Wrapper.m_SueloActionsCallbackInterface.OnSaltar;
                @Interactuar.started -= m_Wrapper.m_SueloActionsCallbackInterface.OnInteractuar;
                @Interactuar.performed -= m_Wrapper.m_SueloActionsCallbackInterface.OnInteractuar;
                @Interactuar.canceled -= m_Wrapper.m_SueloActionsCallbackInterface.OnInteractuar;
                @Menu.started -= m_Wrapper.m_SueloActionsCallbackInterface.OnMenu;
                @Menu.performed -= m_Wrapper.m_SueloActionsCallbackInterface.OnMenu;
                @Menu.canceled -= m_Wrapper.m_SueloActionsCallbackInterface.OnMenu;
            }
            m_Wrapper.m_SueloActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Mover.started += instance.OnMover;
                @Mover.performed += instance.OnMover;
                @Mover.canceled += instance.OnMover;
                @Saltar.started += instance.OnSaltar;
                @Saltar.performed += instance.OnSaltar;
                @Saltar.canceled += instance.OnSaltar;
                @Interactuar.started += instance.OnInteractuar;
                @Interactuar.performed += instance.OnInteractuar;
                @Interactuar.canceled += instance.OnInteractuar;
                @Menu.started += instance.OnMenu;
                @Menu.performed += instance.OnMenu;
                @Menu.canceled += instance.OnMenu;
            }
        }
    }
    public SueloActions @Suelo => new SueloActions(this);

    // SinGravedad
    private readonly InputActionMap m_SinGravedad;
    private ISinGravedadActions m_SinGravedadActionsCallbackInterface;
    private readonly InputAction m_SinGravedad_Propulsar;
    public struct SinGravedadActions
    {
        private @PlayerInputController m_Wrapper;
        public SinGravedadActions(@PlayerInputController wrapper) { m_Wrapper = wrapper; }
        public InputAction @Propulsar => m_Wrapper.m_SinGravedad_Propulsar;
        public InputActionMap Get() { return m_Wrapper.m_SinGravedad; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(SinGravedadActions set) { return set.Get(); }
        public void SetCallbacks(ISinGravedadActions instance)
        {
            if (m_Wrapper.m_SinGravedadActionsCallbackInterface != null)
            {
                @Propulsar.started -= m_Wrapper.m_SinGravedadActionsCallbackInterface.OnPropulsar;
                @Propulsar.performed -= m_Wrapper.m_SinGravedadActionsCallbackInterface.OnPropulsar;
                @Propulsar.canceled -= m_Wrapper.m_SinGravedadActionsCallbackInterface.OnPropulsar;
            }
            m_Wrapper.m_SinGravedadActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Propulsar.started += instance.OnPropulsar;
                @Propulsar.performed += instance.OnPropulsar;
                @Propulsar.canceled += instance.OnPropulsar;
            }
        }
    }
    public SinGravedadActions @SinGravedad => new SinGravedadActions(this);
    public interface ISueloActions
    {
        void OnMover(InputAction.CallbackContext context);
        void OnSaltar(InputAction.CallbackContext context);
        void OnInteractuar(InputAction.CallbackContext context);
        void OnMenu(InputAction.CallbackContext context);
    }
    public interface ISinGravedadActions
    {
        void OnPropulsar(InputAction.CallbackContext context);
    }
}
