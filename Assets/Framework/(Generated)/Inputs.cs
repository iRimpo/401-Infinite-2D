//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.4.3
//     from Assets/Framework/(Generated)/Inputs.inputactions
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

public partial class @Inputs : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @Inputs()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Inputs"",
    ""maps"": [
        {
            ""name"": ""Selector"",
            ""id"": ""972ddb30-a73f-431b-b17b-a3a73a19b930"",
            ""actions"": [
                {
                    ""name"": ""Click"",
                    ""type"": ""Button"",
                    ""id"": ""b896b5d0-3ac8-4a93-8161-4629a776c409"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""MouseMove"",
                    ""type"": ""Value"",
                    ""id"": ""29d525fe-787f-46c7-bf43-5c070d020417"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""MousePos"",
                    ""type"": ""Value"",
                    ""id"": ""e942e3a2-169e-4b06-9f60-ffd2bf41f5f8"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Cancel"",
                    ""type"": ""Button"",
                    ""id"": ""4955685d-c6a5-4e4c-96d7-cf24fcc0e914"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""c0b6ae5f-b9ae-42a5-8bb1-cd5fa23da65b"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Click"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c0d5c308-bda9-49b4-9901-2bc6c56b6e3e"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""MouseMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a60e05bc-af6d-49e1-b669-ba7bf565fa03"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""MousePos"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fbdc5542-f964-47fe-8a03-82677feb2691"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Cancel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Test"",
            ""id"": ""42d876d7-491b-4956-bb48-e9ed5cf003ea"",
            ""actions"": [
                {
                    ""name"": ""moveprompt"",
                    ""type"": ""Button"",
                    ""id"": ""f3ccd87c-cc83-4b3c-930a-45ae925d28b0"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""undo"",
                    ""type"": ""Button"",
                    ""id"": ""c2023c06-d457-4543-8137-6c26a64ffbde"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""effect"",
                    ""type"": ""Button"",
                    ""id"": ""43eecebc-0188-4b84-875a-26c5c28df90c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""20b91085-9530-4594-a719-6f6c20b730fd"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""moveprompt"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5a4787e1-4273-4c89-848e-5ace1dea75d7"",
                    ""path"": ""<Keyboard>/tab"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""undo"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5c6cb82d-f805-4a46-9cd3-379877190f23"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""effect"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard&Mouse"",
            ""bindingGroup"": ""Keyboard&Mouse"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Gamepad"",
            ""bindingGroup"": ""Gamepad"",
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Touch"",
            ""bindingGroup"": ""Touch"",
            ""devices"": [
                {
                    ""devicePath"": ""<Touchscreen>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Joystick"",
            ""bindingGroup"": ""Joystick"",
            ""devices"": [
                {
                    ""devicePath"": ""<Joystick>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""XR"",
            ""bindingGroup"": ""XR"",
            ""devices"": [
                {
                    ""devicePath"": ""<XRController>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Selector
        m_Selector = asset.FindActionMap("Selector", throwIfNotFound: true);
        m_Selector_Click = m_Selector.FindAction("Click", throwIfNotFound: true);
        m_Selector_MouseMove = m_Selector.FindAction("MouseMove", throwIfNotFound: true);
        m_Selector_MousePos = m_Selector.FindAction("MousePos", throwIfNotFound: true);
        m_Selector_Cancel = m_Selector.FindAction("Cancel", throwIfNotFound: true);
        // Test
        m_Test = asset.FindActionMap("Test", throwIfNotFound: true);
        m_Test_moveprompt = m_Test.FindAction("moveprompt", throwIfNotFound: true);
        m_Test_undo = m_Test.FindAction("undo", throwIfNotFound: true);
        m_Test_effect = m_Test.FindAction("effect", throwIfNotFound: true);
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

    // Selector
    private readonly InputActionMap m_Selector;
    private ISelectorActions m_SelectorActionsCallbackInterface;
    private readonly InputAction m_Selector_Click;
    private readonly InputAction m_Selector_MouseMove;
    private readonly InputAction m_Selector_MousePos;
    private readonly InputAction m_Selector_Cancel;
    public struct SelectorActions
    {
        private @Inputs m_Wrapper;
        public SelectorActions(@Inputs wrapper) { m_Wrapper = wrapper; }
        public InputAction @Click => m_Wrapper.m_Selector_Click;
        public InputAction @MouseMove => m_Wrapper.m_Selector_MouseMove;
        public InputAction @MousePos => m_Wrapper.m_Selector_MousePos;
        public InputAction @Cancel => m_Wrapper.m_Selector_Cancel;
        public InputActionMap Get() { return m_Wrapper.m_Selector; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(SelectorActions set) { return set.Get(); }
        public void SetCallbacks(ISelectorActions instance)
        {
            if (m_Wrapper.m_SelectorActionsCallbackInterface != null)
            {
                @Click.started -= m_Wrapper.m_SelectorActionsCallbackInterface.OnClick;
                @Click.performed -= m_Wrapper.m_SelectorActionsCallbackInterface.OnClick;
                @Click.canceled -= m_Wrapper.m_SelectorActionsCallbackInterface.OnClick;
                @MouseMove.started -= m_Wrapper.m_SelectorActionsCallbackInterface.OnMouseMove;
                @MouseMove.performed -= m_Wrapper.m_SelectorActionsCallbackInterface.OnMouseMove;
                @MouseMove.canceled -= m_Wrapper.m_SelectorActionsCallbackInterface.OnMouseMove;
                @MousePos.started -= m_Wrapper.m_SelectorActionsCallbackInterface.OnMousePos;
                @MousePos.performed -= m_Wrapper.m_SelectorActionsCallbackInterface.OnMousePos;
                @MousePos.canceled -= m_Wrapper.m_SelectorActionsCallbackInterface.OnMousePos;
                @Cancel.started -= m_Wrapper.m_SelectorActionsCallbackInterface.OnCancel;
                @Cancel.performed -= m_Wrapper.m_SelectorActionsCallbackInterface.OnCancel;
                @Cancel.canceled -= m_Wrapper.m_SelectorActionsCallbackInterface.OnCancel;
            }
            m_Wrapper.m_SelectorActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Click.started += instance.OnClick;
                @Click.performed += instance.OnClick;
                @Click.canceled += instance.OnClick;
                @MouseMove.started += instance.OnMouseMove;
                @MouseMove.performed += instance.OnMouseMove;
                @MouseMove.canceled += instance.OnMouseMove;
                @MousePos.started += instance.OnMousePos;
                @MousePos.performed += instance.OnMousePos;
                @MousePos.canceled += instance.OnMousePos;
                @Cancel.started += instance.OnCancel;
                @Cancel.performed += instance.OnCancel;
                @Cancel.canceled += instance.OnCancel;
            }
        }
    }
    public SelectorActions @Selector => new SelectorActions(this);

    // Test
    private readonly InputActionMap m_Test;
    private ITestActions m_TestActionsCallbackInterface;
    private readonly InputAction m_Test_moveprompt;
    private readonly InputAction m_Test_undo;
    private readonly InputAction m_Test_effect;
    public struct TestActions
    {
        private @Inputs m_Wrapper;
        public TestActions(@Inputs wrapper) { m_Wrapper = wrapper; }
        public InputAction @moveprompt => m_Wrapper.m_Test_moveprompt;
        public InputAction @undo => m_Wrapper.m_Test_undo;
        public InputAction @effect => m_Wrapper.m_Test_effect;
        public InputActionMap Get() { return m_Wrapper.m_Test; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(TestActions set) { return set.Get(); }
        public void SetCallbacks(ITestActions instance)
        {
            if (m_Wrapper.m_TestActionsCallbackInterface != null)
            {
                @moveprompt.started -= m_Wrapper.m_TestActionsCallbackInterface.OnMoveprompt;
                @moveprompt.performed -= m_Wrapper.m_TestActionsCallbackInterface.OnMoveprompt;
                @moveprompt.canceled -= m_Wrapper.m_TestActionsCallbackInterface.OnMoveprompt;
                @undo.started -= m_Wrapper.m_TestActionsCallbackInterface.OnUndo;
                @undo.performed -= m_Wrapper.m_TestActionsCallbackInterface.OnUndo;
                @undo.canceled -= m_Wrapper.m_TestActionsCallbackInterface.OnUndo;
                @effect.started -= m_Wrapper.m_TestActionsCallbackInterface.OnEffect;
                @effect.performed -= m_Wrapper.m_TestActionsCallbackInterface.OnEffect;
                @effect.canceled -= m_Wrapper.m_TestActionsCallbackInterface.OnEffect;
            }
            m_Wrapper.m_TestActionsCallbackInterface = instance;
            if (instance != null)
            {
                @moveprompt.started += instance.OnMoveprompt;
                @moveprompt.performed += instance.OnMoveprompt;
                @moveprompt.canceled += instance.OnMoveprompt;
                @undo.started += instance.OnUndo;
                @undo.performed += instance.OnUndo;
                @undo.canceled += instance.OnUndo;
                @effect.started += instance.OnEffect;
                @effect.performed += instance.OnEffect;
                @effect.canceled += instance.OnEffect;
            }
        }
    }
    public TestActions @Test => new TestActions(this);
    private int m_KeyboardMouseSchemeIndex = -1;
    public InputControlScheme KeyboardMouseScheme
    {
        get
        {
            if (m_KeyboardMouseSchemeIndex == -1) m_KeyboardMouseSchemeIndex = asset.FindControlSchemeIndex("Keyboard&Mouse");
            return asset.controlSchemes[m_KeyboardMouseSchemeIndex];
        }
    }
    private int m_GamepadSchemeIndex = -1;
    public InputControlScheme GamepadScheme
    {
        get
        {
            if (m_GamepadSchemeIndex == -1) m_GamepadSchemeIndex = asset.FindControlSchemeIndex("Gamepad");
            return asset.controlSchemes[m_GamepadSchemeIndex];
        }
    }
    private int m_TouchSchemeIndex = -1;
    public InputControlScheme TouchScheme
    {
        get
        {
            if (m_TouchSchemeIndex == -1) m_TouchSchemeIndex = asset.FindControlSchemeIndex("Touch");
            return asset.controlSchemes[m_TouchSchemeIndex];
        }
    }
    private int m_JoystickSchemeIndex = -1;
    public InputControlScheme JoystickScheme
    {
        get
        {
            if (m_JoystickSchemeIndex == -1) m_JoystickSchemeIndex = asset.FindControlSchemeIndex("Joystick");
            return asset.controlSchemes[m_JoystickSchemeIndex];
        }
    }
    private int m_XRSchemeIndex = -1;
    public InputControlScheme XRScheme
    {
        get
        {
            if (m_XRSchemeIndex == -1) m_XRSchemeIndex = asset.FindControlSchemeIndex("XR");
            return asset.controlSchemes[m_XRSchemeIndex];
        }
    }
    public interface ISelectorActions
    {
        void OnClick(InputAction.CallbackContext context);
        void OnMouseMove(InputAction.CallbackContext context);
        void OnMousePos(InputAction.CallbackContext context);
        void OnCancel(InputAction.CallbackContext context);
    }
    public interface ITestActions
    {
        void OnMoveprompt(InputAction.CallbackContext context);
        void OnUndo(InputAction.CallbackContext context);
        void OnEffect(InputAction.CallbackContext context);
    }
}
