// GENERATED AUTOMATICALLY FROM 'Assets/Script/Mechanics/Input/InputControll.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @InputControll : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputControll()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputControll"",
    ""maps"": [
        {
            ""name"": ""Touch"",
            ""id"": ""5c43245d-6a67-4768-bd8f-3c12d6bc8e0b"",
            ""actions"": [
                {
                    ""name"": ""PrimaryContact"",
                    ""type"": ""PassThrough"",
                    ""id"": ""0cfae4f4-ce88-4962-a98e-2338fbcfef30"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""PrimaryPosition"",
                    ""type"": ""PassThrough"",
                    ""id"": ""6ffaf77b-da95-4482-856a-5ebf3dd3fb5b"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""TwoContact"",
                    ""type"": ""PassThrough"",
                    ""id"": ""4da83382-64d0-4e8d-903e-417ae6f1b9df"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""TwoPosition"",
                    ""type"": ""PassThrough"",
                    ""id"": ""0e2b12ec-4061-4829-8b69-25c14ba7d48b"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Scroll"",
                    ""type"": ""Value"",
                    ""id"": ""00a5c38b-719c-44d4-a198-f5dbbf7ff4a9"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""PrimaryDelta"",
                    ""type"": ""PassThrough"",
                    ""id"": ""29b52e65-d190-4b1a-b869-006d3aca3cbf"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""TwoDelta"",
                    ""type"": ""PassThrough"",
                    ""id"": ""7f516526-437b-4325-9ceb-6d3cad7a67d8"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""187555dd-9b69-4515-8d9f-bd01cfc14270"",
                    ""path"": ""<Touchscreen>/primaryTouch/press"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": ""Touch"",
                    ""action"": ""PrimaryContact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6c92cb27-7930-474a-86bf-45db5152aa1a"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse"",
                    ""action"": ""PrimaryContact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8b8a81aa-67fb-4bf9-84ac-bbb366674627"",
                    ""path"": ""<Touchscreen>/primaryTouch/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Touch"",
                    ""action"": ""PrimaryPosition"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""76a9b220-8cff-4aa1-9f46-5ee4952bf8e1"",
                    ""path"": ""<Pointer>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse"",
                    ""action"": ""PrimaryPosition"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""99ee40f4-dfae-4151-b24f-4cd43d2d7d71"",
                    ""path"": ""<Touchscreen>/touch1/press"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": ""Touch"",
                    ""action"": ""TwoContact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d0373bf4-63ed-43bc-8286-74021434a556"",
                    ""path"": ""<Touchscreen>/touch1/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Touch"",
                    ""action"": ""TwoPosition"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""27ce77e7-7c29-483c-bf84-84b97451cf6c"",
                    ""path"": ""<Mouse>/scroll"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse"",
                    ""action"": ""Scroll"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5539eaf4-c094-4f99-aa84-ada1646bdeae"",
                    ""path"": ""<Touchscreen>/primaryTouch/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Touch"",
                    ""action"": ""PrimaryDelta"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d650cfba-1d6b-4dd5-a78f-21d388363fa9"",
                    ""path"": ""<Touchscreen>/touch1/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Touch"",
                    ""action"": ""TwoDelta"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Touch"",
            ""bindingGroup"": ""Touch"",
            ""devices"": []
        },
        {
            ""name"": ""Mouse"",
            ""bindingGroup"": ""Mouse"",
            ""devices"": []
        }
    ]
}");
        // Touch
        m_Touch = asset.FindActionMap("Touch", throwIfNotFound: true);
        m_Touch_PrimaryContact = m_Touch.FindAction("PrimaryContact", throwIfNotFound: true);
        m_Touch_PrimaryPosition = m_Touch.FindAction("PrimaryPosition", throwIfNotFound: true);
        m_Touch_TwoContact = m_Touch.FindAction("TwoContact", throwIfNotFound: true);
        m_Touch_TwoPosition = m_Touch.FindAction("TwoPosition", throwIfNotFound: true);
        m_Touch_Scroll = m_Touch.FindAction("Scroll", throwIfNotFound: true);
        m_Touch_PrimaryDelta = m_Touch.FindAction("PrimaryDelta", throwIfNotFound: true);
        m_Touch_TwoDelta = m_Touch.FindAction("TwoDelta", throwIfNotFound: true);
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

    // Touch
    private readonly InputActionMap m_Touch;
    private ITouchActions m_TouchActionsCallbackInterface;
    private readonly InputAction m_Touch_PrimaryContact;
    private readonly InputAction m_Touch_PrimaryPosition;
    private readonly InputAction m_Touch_TwoContact;
    private readonly InputAction m_Touch_TwoPosition;
    private readonly InputAction m_Touch_Scroll;
    private readonly InputAction m_Touch_PrimaryDelta;
    private readonly InputAction m_Touch_TwoDelta;
    public struct TouchActions
    {
        private @InputControll m_Wrapper;
        public TouchActions(@InputControll wrapper) { m_Wrapper = wrapper; }
        public InputAction @PrimaryContact => m_Wrapper.m_Touch_PrimaryContact;
        public InputAction @PrimaryPosition => m_Wrapper.m_Touch_PrimaryPosition;
        public InputAction @TwoContact => m_Wrapper.m_Touch_TwoContact;
        public InputAction @TwoPosition => m_Wrapper.m_Touch_TwoPosition;
        public InputAction @Scroll => m_Wrapper.m_Touch_Scroll;
        public InputAction @PrimaryDelta => m_Wrapper.m_Touch_PrimaryDelta;
        public InputAction @TwoDelta => m_Wrapper.m_Touch_TwoDelta;
        public InputActionMap Get() { return m_Wrapper.m_Touch; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(TouchActions set) { return set.Get(); }
        public void SetCallbacks(ITouchActions instance)
        {
            if (m_Wrapper.m_TouchActionsCallbackInterface != null)
            {
                @PrimaryContact.started -= m_Wrapper.m_TouchActionsCallbackInterface.OnPrimaryContact;
                @PrimaryContact.performed -= m_Wrapper.m_TouchActionsCallbackInterface.OnPrimaryContact;
                @PrimaryContact.canceled -= m_Wrapper.m_TouchActionsCallbackInterface.OnPrimaryContact;
                @PrimaryPosition.started -= m_Wrapper.m_TouchActionsCallbackInterface.OnPrimaryPosition;
                @PrimaryPosition.performed -= m_Wrapper.m_TouchActionsCallbackInterface.OnPrimaryPosition;
                @PrimaryPosition.canceled -= m_Wrapper.m_TouchActionsCallbackInterface.OnPrimaryPosition;
                @TwoContact.started -= m_Wrapper.m_TouchActionsCallbackInterface.OnTwoContact;
                @TwoContact.performed -= m_Wrapper.m_TouchActionsCallbackInterface.OnTwoContact;
                @TwoContact.canceled -= m_Wrapper.m_TouchActionsCallbackInterface.OnTwoContact;
                @TwoPosition.started -= m_Wrapper.m_TouchActionsCallbackInterface.OnTwoPosition;
                @TwoPosition.performed -= m_Wrapper.m_TouchActionsCallbackInterface.OnTwoPosition;
                @TwoPosition.canceled -= m_Wrapper.m_TouchActionsCallbackInterface.OnTwoPosition;
                @Scroll.started -= m_Wrapper.m_TouchActionsCallbackInterface.OnScroll;
                @Scroll.performed -= m_Wrapper.m_TouchActionsCallbackInterface.OnScroll;
                @Scroll.canceled -= m_Wrapper.m_TouchActionsCallbackInterface.OnScroll;
                @PrimaryDelta.started -= m_Wrapper.m_TouchActionsCallbackInterface.OnPrimaryDelta;
                @PrimaryDelta.performed -= m_Wrapper.m_TouchActionsCallbackInterface.OnPrimaryDelta;
                @PrimaryDelta.canceled -= m_Wrapper.m_TouchActionsCallbackInterface.OnPrimaryDelta;
                @TwoDelta.started -= m_Wrapper.m_TouchActionsCallbackInterface.OnTwoDelta;
                @TwoDelta.performed -= m_Wrapper.m_TouchActionsCallbackInterface.OnTwoDelta;
                @TwoDelta.canceled -= m_Wrapper.m_TouchActionsCallbackInterface.OnTwoDelta;
            }
            m_Wrapper.m_TouchActionsCallbackInterface = instance;
            if (instance != null)
            {
                @PrimaryContact.started += instance.OnPrimaryContact;
                @PrimaryContact.performed += instance.OnPrimaryContact;
                @PrimaryContact.canceled += instance.OnPrimaryContact;
                @PrimaryPosition.started += instance.OnPrimaryPosition;
                @PrimaryPosition.performed += instance.OnPrimaryPosition;
                @PrimaryPosition.canceled += instance.OnPrimaryPosition;
                @TwoContact.started += instance.OnTwoContact;
                @TwoContact.performed += instance.OnTwoContact;
                @TwoContact.canceled += instance.OnTwoContact;
                @TwoPosition.started += instance.OnTwoPosition;
                @TwoPosition.performed += instance.OnTwoPosition;
                @TwoPosition.canceled += instance.OnTwoPosition;
                @Scroll.started += instance.OnScroll;
                @Scroll.performed += instance.OnScroll;
                @Scroll.canceled += instance.OnScroll;
                @PrimaryDelta.started += instance.OnPrimaryDelta;
                @PrimaryDelta.performed += instance.OnPrimaryDelta;
                @PrimaryDelta.canceled += instance.OnPrimaryDelta;
                @TwoDelta.started += instance.OnTwoDelta;
                @TwoDelta.performed += instance.OnTwoDelta;
                @TwoDelta.canceled += instance.OnTwoDelta;
            }
        }
    }
    public TouchActions @Touch => new TouchActions(this);
    private int m_TouchSchemeIndex = -1;
    public InputControlScheme TouchScheme
    {
        get
        {
            if (m_TouchSchemeIndex == -1) m_TouchSchemeIndex = asset.FindControlSchemeIndex("Touch");
            return asset.controlSchemes[m_TouchSchemeIndex];
        }
    }
    private int m_MouseSchemeIndex = -1;
    public InputControlScheme MouseScheme
    {
        get
        {
            if (m_MouseSchemeIndex == -1) m_MouseSchemeIndex = asset.FindControlSchemeIndex("Mouse");
            return asset.controlSchemes[m_MouseSchemeIndex];
        }
    }
    public interface ITouchActions
    {
        void OnPrimaryContact(InputAction.CallbackContext context);
        void OnPrimaryPosition(InputAction.CallbackContext context);
        void OnTwoContact(InputAction.CallbackContext context);
        void OnTwoPosition(InputAction.CallbackContext context);
        void OnScroll(InputAction.CallbackContext context);
        void OnPrimaryDelta(InputAction.CallbackContext context);
        void OnTwoDelta(InputAction.CallbackContext context);
    }
}
