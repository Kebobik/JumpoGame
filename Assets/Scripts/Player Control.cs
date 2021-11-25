// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/Player Control.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerControl : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerControl()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Player Control"",
    ""maps"": [
        {
            ""name"": ""Zeme"",
            ""id"": ""6972c031-f851-4062-9e96-d243030b99d6"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""69f167ba-b159-4421-a983-7d74315aed77"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=2)""
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""276d910b-4648-41d7-b924-f42e350b90d5"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""14909d54-062b-4036-a8b4-dc36f47434d4"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""8e68ae7d-db1c-479d-86cb-795241ccda72"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""851bdc74-1264-4f80-a15d-b6622acce7d7"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""1D Axis AD"",
                    ""id"": ""37b8d840-b518-4a5e-9327-1e3be3e78b98"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""0dbbe296-3fd6-4bf4-8448-09bbdcc3e753"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""8f92e7d8-22f1-4c8f-9245-ddab0e49e930"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Zeme
        m_Zeme = asset.FindActionMap("Zeme", throwIfNotFound: true);
        m_Zeme_Move = m_Zeme.FindAction("Move", throwIfNotFound: true);
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

    // Zeme
    private readonly InputActionMap m_Zeme;
    private IZemeActions m_ZemeActionsCallbackInterface;
    private readonly InputAction m_Zeme_Move;
    public struct ZemeActions
    {
        private @PlayerControl m_Wrapper;
        public ZemeActions(@PlayerControl wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Zeme_Move;
        public InputActionMap Get() { return m_Wrapper.m_Zeme; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(ZemeActions set) { return set.Get(); }
        public void SetCallbacks(IZemeActions instance)
        {
            if (m_Wrapper.m_ZemeActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_ZemeActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_ZemeActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_ZemeActionsCallbackInterface.OnMove;
            }
            m_Wrapper.m_ZemeActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
            }
        }
    }
    public ZemeActions @Zeme => new ZemeActions(this);
    public interface IZemeActions
    {
        void OnMove(InputAction.CallbackContext context);
    }
}
