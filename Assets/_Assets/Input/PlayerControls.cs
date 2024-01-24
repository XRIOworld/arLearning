//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.7.0
//     from Assets/_Assets/Input/PlayerControls.inputactions
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

public partial class @PlayerControls: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControls"",
    ""maps"": [
        {
            ""name"": ""Space"",
            ""id"": ""c7f40b40-ad60-444a-bf55-a0c8e0b4e63b"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""482bad87-7a67-4cc9-ba17-b3a9befac4ea"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""b79e80f0-90aa-4687-8bfe-48ebd5b9b8d5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Floated"",
                    ""type"": ""Value"",
                    ""id"": ""37cb3c6a-84dc-430b-b2dc-5260a3f61be6"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Spawn"",
                    ""type"": ""Button"",
                    ""id"": ""4a9c9d48-e003-4e20-890d-e8f22ba86840"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Elevate"",
                    ""type"": ""Value"",
                    ""id"": ""1f453a4c-03f1-4946-9df0-9c83277f2b78"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Rotate"",
                    ""type"": ""Value"",
                    ""id"": ""69fac68b-68a2-48ac-80c5-30711809aa9a"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Grab"",
                    ""type"": ""Button"",
                    ""id"": ""196b8d33-ad8c-450d-97df-71c5f727a019"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Release"",
                    ""type"": ""Button"",
                    ""id"": ""8aa2a0ff-3ab4-4c5f-9b51-89207686c9f2"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""09e1ed2f-00a6-4ec8-aa9f-3abe33768e9e"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""4eb6820a-b4ec-407c-96f8-137de01790cf"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""6ba1496d-c72c-4244-bfca-8534333fc210"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""24f64cd2-0f52-4c98-9aac-f316a37c8481"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""5869f1f0-d2d7-41f6-bee0-997dad74c223"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""a47442e7-37c0-47c3-9761-4bc17f3b807a"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8ae6f393-08c1-4786-be40-40f39b482796"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""378238fd-dc6b-4ec2-a54a-9689c080f47b"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Floated"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""c87e273a-a106-4802-93f1-23a5ba46265c"",
                    ""path"": ""<Keyboard>/p"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Floated"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""4721c789-dc6a-4a45-b0ca-7d6c83a5505b"",
                    ""path"": ""<Keyboard>/l"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Floated"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""2e39f96f-ba3e-498e-955f-53dc9aa21a81"",
                    ""path"": ""<Keyboard>/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Spawn"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""a67dcdd7-e842-4660-a3aa-f75348bf17e9"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Elevate"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""d2b1a37d-935a-4018-bff2-0628fac3f0a7"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Elevate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""51d67abc-61df-451f-b9eb-8012d27ab101"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Elevate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Left Right arrows"",
                    ""id"": ""c2221217-d632-44ab-9d1e-1c77e8ae9fbd"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotate"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""abaeb8f6-b06e-42dd-815c-6553ab3b4b90"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""9ae0f5da-1fc3-445b-87a1-b7950f5c6c58"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""6b002f71-d725-4bed-af64-0c22b272dda1"",
                    ""path"": ""<Keyboard>/g"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Grab"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""597a85f1-3e50-4e66-904f-5690e77f365c"",
                    ""path"": ""<Keyboard>/r"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Release"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Space
        m_Space = asset.FindActionMap("Space", throwIfNotFound: true);
        m_Space_Move = m_Space.FindAction("Move", throwIfNotFound: true);
        m_Space_Jump = m_Space.FindAction("Jump", throwIfNotFound: true);
        m_Space_Floated = m_Space.FindAction("Floated", throwIfNotFound: true);
        m_Space_Spawn = m_Space.FindAction("Spawn", throwIfNotFound: true);
        m_Space_Elevate = m_Space.FindAction("Elevate", throwIfNotFound: true);
        m_Space_Rotate = m_Space.FindAction("Rotate", throwIfNotFound: true);
        m_Space_Grab = m_Space.FindAction("Grab", throwIfNotFound: true);
        m_Space_Release = m_Space.FindAction("Release", throwIfNotFound: true);
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

    // Space
    private readonly InputActionMap m_Space;
    private List<ISpaceActions> m_SpaceActionsCallbackInterfaces = new List<ISpaceActions>();
    private readonly InputAction m_Space_Move;
    private readonly InputAction m_Space_Jump;
    private readonly InputAction m_Space_Floated;
    private readonly InputAction m_Space_Spawn;
    private readonly InputAction m_Space_Elevate;
    private readonly InputAction m_Space_Rotate;
    private readonly InputAction m_Space_Grab;
    private readonly InputAction m_Space_Release;
    public struct SpaceActions
    {
        private @PlayerControls m_Wrapper;
        public SpaceActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Space_Move;
        public InputAction @Jump => m_Wrapper.m_Space_Jump;
        public InputAction @Floated => m_Wrapper.m_Space_Floated;
        public InputAction @Spawn => m_Wrapper.m_Space_Spawn;
        public InputAction @Elevate => m_Wrapper.m_Space_Elevate;
        public InputAction @Rotate => m_Wrapper.m_Space_Rotate;
        public InputAction @Grab => m_Wrapper.m_Space_Grab;
        public InputAction @Release => m_Wrapper.m_Space_Release;
        public InputActionMap Get() { return m_Wrapper.m_Space; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(SpaceActions set) { return set.Get(); }
        public void AddCallbacks(ISpaceActions instance)
        {
            if (instance == null || m_Wrapper.m_SpaceActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_SpaceActionsCallbackInterfaces.Add(instance);
            @Move.started += instance.OnMove;
            @Move.performed += instance.OnMove;
            @Move.canceled += instance.OnMove;
            @Jump.started += instance.OnJump;
            @Jump.performed += instance.OnJump;
            @Jump.canceled += instance.OnJump;
            @Floated.started += instance.OnFloated;
            @Floated.performed += instance.OnFloated;
            @Floated.canceled += instance.OnFloated;
            @Spawn.started += instance.OnSpawn;
            @Spawn.performed += instance.OnSpawn;
            @Spawn.canceled += instance.OnSpawn;
            @Elevate.started += instance.OnElevate;
            @Elevate.performed += instance.OnElevate;
            @Elevate.canceled += instance.OnElevate;
            @Rotate.started += instance.OnRotate;
            @Rotate.performed += instance.OnRotate;
            @Rotate.canceled += instance.OnRotate;
            @Grab.started += instance.OnGrab;
            @Grab.performed += instance.OnGrab;
            @Grab.canceled += instance.OnGrab;
            @Release.started += instance.OnRelease;
            @Release.performed += instance.OnRelease;
            @Release.canceled += instance.OnRelease;
        }

        private void UnregisterCallbacks(ISpaceActions instance)
        {
            @Move.started -= instance.OnMove;
            @Move.performed -= instance.OnMove;
            @Move.canceled -= instance.OnMove;
            @Jump.started -= instance.OnJump;
            @Jump.performed -= instance.OnJump;
            @Jump.canceled -= instance.OnJump;
            @Floated.started -= instance.OnFloated;
            @Floated.performed -= instance.OnFloated;
            @Floated.canceled -= instance.OnFloated;
            @Spawn.started -= instance.OnSpawn;
            @Spawn.performed -= instance.OnSpawn;
            @Spawn.canceled -= instance.OnSpawn;
            @Elevate.started -= instance.OnElevate;
            @Elevate.performed -= instance.OnElevate;
            @Elevate.canceled -= instance.OnElevate;
            @Rotate.started -= instance.OnRotate;
            @Rotate.performed -= instance.OnRotate;
            @Rotate.canceled -= instance.OnRotate;
            @Grab.started -= instance.OnGrab;
            @Grab.performed -= instance.OnGrab;
            @Grab.canceled -= instance.OnGrab;
            @Release.started -= instance.OnRelease;
            @Release.performed -= instance.OnRelease;
            @Release.canceled -= instance.OnRelease;
        }

        public void RemoveCallbacks(ISpaceActions instance)
        {
            if (m_Wrapper.m_SpaceActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(ISpaceActions instance)
        {
            foreach (var item in m_Wrapper.m_SpaceActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_SpaceActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public SpaceActions @Space => new SpaceActions(this);
    public interface ISpaceActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnFloated(InputAction.CallbackContext context);
        void OnSpawn(InputAction.CallbackContext context);
        void OnElevate(InputAction.CallbackContext context);
        void OnRotate(InputAction.CallbackContext context);
        void OnGrab(InputAction.CallbackContext context);
        void OnRelease(InputAction.CallbackContext context);
    }
}
