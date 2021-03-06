// GENERATED AUTOMATICALLY FROM 'Assets/Input Actions/PlayerInputActions.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerInputActions : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInputActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInputActions"",
    ""maps"": [
        {
            ""name"": ""Playing"",
            ""id"": ""e3b2a8ac-3233-427e-92d3-9f78f2669e18"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""PassThrough"",
                    ""id"": ""a8699b73-65ff-4562-8204-018dd3fa7fb7"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Inventory"",
                    ""type"": ""Button"",
                    ""id"": ""9c79a365-922f-4470-8d4e-4c6c07a31e18"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Use"",
                    ""type"": ""Button"",
                    ""id"": ""7fa320ec-2e6d-4359-a5ff-128fb1d81405"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""NumKeys"",
                    ""type"": ""Button"",
                    ""id"": ""59662a04-ce3d-43e8-8550-8b5ee13cdb81"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""635ccb15-818a-4c25-9aad-ae8a74fa7da1"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""4c8f6072-6233-45bd-b694-2ac01d4cb0f5"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse & Keyboard"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""eae5303d-a068-429a-b427-d396b4c48f4b"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse & Keyboard"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""67610eee-eb95-4f9c-a6e8-7191e04c82bc"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse & Keyboard"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""42c3338d-3e7c-4f75-99a5-f70b3a0fd132"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse & Keyboard"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""3b030076-946c-46f9-bab8-d6a336c59cc5"",
                    ""path"": ""<Keyboard>/tab"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": ""Mouse & Keyboard"",
                    ""action"": ""Inventory"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1f932bce-96e7-49f3-abec-06b9fa9718c3"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": ""Mouse & Keyboard"",
                    ""action"": ""Use"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ab6e002b-c40d-42a8-9b8d-3e0552e1d7ab"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse & Keyboard"",
                    ""action"": ""NumKeys"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Shop"",
            ""id"": ""bcce73d1-ff5c-4835-a7f1-20323c1af7f6"",
            ""actions"": [
                {
                    ""name"": ""New action"",
                    ""type"": ""Button"",
                    ""id"": ""d23dc1a1-c163-41f3-96ee-7f6e24a4fd05"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""49784cc1-e390-4bb3-98c2-83d9d86fb73e"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""New action"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Mouse & Keyboard"",
            ""bindingGroup"": ""Mouse & Keyboard"",
            ""devices"": [
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Playing
        m_Playing = asset.FindActionMap("Playing", throwIfNotFound: true);
        m_Playing_Movement = m_Playing.FindAction("Movement", throwIfNotFound: true);
        m_Playing_Inventory = m_Playing.FindAction("Inventory", throwIfNotFound: true);
        m_Playing_Use = m_Playing.FindAction("Use", throwIfNotFound: true);
        m_Playing_NumKeys = m_Playing.FindAction("NumKeys", throwIfNotFound: true);
        // Shop
        m_Shop = asset.FindActionMap("Shop", throwIfNotFound: true);
        m_Shop_Newaction = m_Shop.FindAction("New action", throwIfNotFound: true);
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

    // Playing
    private readonly InputActionMap m_Playing;
    private IPlayingActions m_PlayingActionsCallbackInterface;
    private readonly InputAction m_Playing_Movement;
    private readonly InputAction m_Playing_Inventory;
    private readonly InputAction m_Playing_Use;
    private readonly InputAction m_Playing_NumKeys;
    public struct PlayingActions
    {
        private @PlayerInputActions m_Wrapper;
        public PlayingActions(@PlayerInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_Playing_Movement;
        public InputAction @Inventory => m_Wrapper.m_Playing_Inventory;
        public InputAction @Use => m_Wrapper.m_Playing_Use;
        public InputAction @NumKeys => m_Wrapper.m_Playing_NumKeys;
        public InputActionMap Get() { return m_Wrapper.m_Playing; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayingActions set) { return set.Get(); }
        public void SetCallbacks(IPlayingActions instance)
        {
            if (m_Wrapper.m_PlayingActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_PlayingActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_PlayingActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_PlayingActionsCallbackInterface.OnMovement;
                @Inventory.started -= m_Wrapper.m_PlayingActionsCallbackInterface.OnInventory;
                @Inventory.performed -= m_Wrapper.m_PlayingActionsCallbackInterface.OnInventory;
                @Inventory.canceled -= m_Wrapper.m_PlayingActionsCallbackInterface.OnInventory;
                @Use.started -= m_Wrapper.m_PlayingActionsCallbackInterface.OnUse;
                @Use.performed -= m_Wrapper.m_PlayingActionsCallbackInterface.OnUse;
                @Use.canceled -= m_Wrapper.m_PlayingActionsCallbackInterface.OnUse;
                @NumKeys.started -= m_Wrapper.m_PlayingActionsCallbackInterface.OnNumKeys;
                @NumKeys.performed -= m_Wrapper.m_PlayingActionsCallbackInterface.OnNumKeys;
                @NumKeys.canceled -= m_Wrapper.m_PlayingActionsCallbackInterface.OnNumKeys;
            }
            m_Wrapper.m_PlayingActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @Inventory.started += instance.OnInventory;
                @Inventory.performed += instance.OnInventory;
                @Inventory.canceled += instance.OnInventory;
                @Use.started += instance.OnUse;
                @Use.performed += instance.OnUse;
                @Use.canceled += instance.OnUse;
                @NumKeys.started += instance.OnNumKeys;
                @NumKeys.performed += instance.OnNumKeys;
                @NumKeys.canceled += instance.OnNumKeys;
            }
        }
    }
    public PlayingActions @Playing => new PlayingActions(this);

    // Shop
    private readonly InputActionMap m_Shop;
    private IShopActions m_ShopActionsCallbackInterface;
    private readonly InputAction m_Shop_Newaction;
    public struct ShopActions
    {
        private @PlayerInputActions m_Wrapper;
        public ShopActions(@PlayerInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Newaction => m_Wrapper.m_Shop_Newaction;
        public InputActionMap Get() { return m_Wrapper.m_Shop; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(ShopActions set) { return set.Get(); }
        public void SetCallbacks(IShopActions instance)
        {
            if (m_Wrapper.m_ShopActionsCallbackInterface != null)
            {
                @Newaction.started -= m_Wrapper.m_ShopActionsCallbackInterface.OnNewaction;
                @Newaction.performed -= m_Wrapper.m_ShopActionsCallbackInterface.OnNewaction;
                @Newaction.canceled -= m_Wrapper.m_ShopActionsCallbackInterface.OnNewaction;
            }
            m_Wrapper.m_ShopActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Newaction.started += instance.OnNewaction;
                @Newaction.performed += instance.OnNewaction;
                @Newaction.canceled += instance.OnNewaction;
            }
        }
    }
    public ShopActions @Shop => new ShopActions(this);
    private int m_MouseKeyboardSchemeIndex = -1;
    public InputControlScheme MouseKeyboardScheme
    {
        get
        {
            if (m_MouseKeyboardSchemeIndex == -1) m_MouseKeyboardSchemeIndex = asset.FindControlSchemeIndex("Mouse & Keyboard");
            return asset.controlSchemes[m_MouseKeyboardSchemeIndex];
        }
    }
    public interface IPlayingActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnInventory(InputAction.CallbackContext context);
        void OnUse(InputAction.CallbackContext context);
        void OnNumKeys(InputAction.CallbackContext context);
    }
    public interface IShopActions
    {
        void OnNewaction(InputAction.CallbackContext context);
    }
}
