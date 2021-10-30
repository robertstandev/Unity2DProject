// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/Player/PlayerInputManager.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerInputManager : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInputManager()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInputManager"",
    ""maps"": [
        {
            ""name"": ""Gameplay"",
            ""id"": ""f71678bd-03f9-4310-893a-808cb0e80b64"",
            ""actions"": [
                {
                    ""name"": ""MovementInput"",
                    ""type"": ""Value"",
                    ""id"": ""53faeefc-9152-4810-bae1-49c585d7e47b"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""UpInput"",
                    ""type"": ""Button"",
                    ""id"": ""23fafd7e-a5a9-4e52-be40-b1e014d74f0f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""DownInput"",
                    ""type"": ""Button"",
                    ""id"": ""0f589ccf-3329-4b36-9359-fce379c55173"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""JumpInput"",
                    ""type"": ""Button"",
                    ""id"": ""2421e051-0ff1-4fcd-b6b4-0b05fcb6eb93"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""SlashInput"",
                    ""type"": ""Button"",
                    ""id"": ""873be9e9-284e-4ac6-84c3-d862e0d6beab"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ProjectileInput"",
                    ""type"": ""Button"",
                    ""id"": ""f9426cc9-7f62-4bee-adc6-adf47ff43207"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MenuInput"",
                    ""type"": ""Button"",
                    ""id"": ""52fd1212-9c0b-4bf5-8af3-611d4cde016a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""432a74e1-30f8-4264-82a7-c6ddb8855870"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MovementInput"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""59281441-109c-43dc-85b5-b53f6fff6ba8"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MovementInput"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""b83c378a-d3e4-4980-924c-90a737c4012d"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MovementInput"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""c774bb1e-534e-4ece-a805-fd2df2729671"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""UpInput"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""697519f4-d129-4050-88d1-90e1c12e1afc"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DownInput"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e4c4346e-2887-4ffc-a8c9-6980e441fb56"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""JumpInput"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a308f387-96fc-4051-b379-cad7627627d1"",
                    ""path"": ""<Keyboard>/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SlashInput"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9ead76a4-2165-4dc3-b3b5-f94d6ed3413a"",
                    ""path"": ""<Keyboard>/z"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ProjectileInput"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""efe10885-443f-47d4-8817-26d587eff011"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MenuInput"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Gameplay
        m_Gameplay = asset.FindActionMap("Gameplay", throwIfNotFound: true);
        m_Gameplay_MovementInput = m_Gameplay.FindAction("MovementInput", throwIfNotFound: true);
        m_Gameplay_UpInput = m_Gameplay.FindAction("UpInput", throwIfNotFound: true);
        m_Gameplay_DownInput = m_Gameplay.FindAction("DownInput", throwIfNotFound: true);
        m_Gameplay_JumpInput = m_Gameplay.FindAction("JumpInput", throwIfNotFound: true);
        m_Gameplay_SlashInput = m_Gameplay.FindAction("SlashInput", throwIfNotFound: true);
        m_Gameplay_ProjectileInput = m_Gameplay.FindAction("ProjectileInput", throwIfNotFound: true);
        m_Gameplay_MenuInput = m_Gameplay.FindAction("MenuInput", throwIfNotFound: true);
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

    // Gameplay
    private readonly InputActionMap m_Gameplay;
    private IGameplayActions m_GameplayActionsCallbackInterface;
    private readonly InputAction m_Gameplay_MovementInput;
    private readonly InputAction m_Gameplay_UpInput;
    private readonly InputAction m_Gameplay_DownInput;
    private readonly InputAction m_Gameplay_JumpInput;
    private readonly InputAction m_Gameplay_SlashInput;
    private readonly InputAction m_Gameplay_ProjectileInput;
    private readonly InputAction m_Gameplay_MenuInput;
    public struct GameplayActions
    {
        private @PlayerInputManager m_Wrapper;
        public GameplayActions(@PlayerInputManager wrapper) { m_Wrapper = wrapper; }
        public InputAction @MovementInput => m_Wrapper.m_Gameplay_MovementInput;
        public InputAction @UpInput => m_Wrapper.m_Gameplay_UpInput;
        public InputAction @DownInput => m_Wrapper.m_Gameplay_DownInput;
        public InputAction @JumpInput => m_Wrapper.m_Gameplay_JumpInput;
        public InputAction @SlashInput => m_Wrapper.m_Gameplay_SlashInput;
        public InputAction @ProjectileInput => m_Wrapper.m_Gameplay_ProjectileInput;
        public InputAction @MenuInput => m_Wrapper.m_Gameplay_MenuInput;
        public InputActionMap Get() { return m_Wrapper.m_Gameplay; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GameplayActions set) { return set.Get(); }
        public void SetCallbacks(IGameplayActions instance)
        {
            if (m_Wrapper.m_GameplayActionsCallbackInterface != null)
            {
                @MovementInput.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMovementInput;
                @MovementInput.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMovementInput;
                @MovementInput.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMovementInput;
                @UpInput.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnUpInput;
                @UpInput.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnUpInput;
                @UpInput.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnUpInput;
                @DownInput.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnDownInput;
                @DownInput.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnDownInput;
                @DownInput.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnDownInput;
                @JumpInput.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnJumpInput;
                @JumpInput.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnJumpInput;
                @JumpInput.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnJumpInput;
                @SlashInput.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnSlashInput;
                @SlashInput.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnSlashInput;
                @SlashInput.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnSlashInput;
                @ProjectileInput.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnProjectileInput;
                @ProjectileInput.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnProjectileInput;
                @ProjectileInput.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnProjectileInput;
                @MenuInput.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMenuInput;
                @MenuInput.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMenuInput;
                @MenuInput.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMenuInput;
            }
            m_Wrapper.m_GameplayActionsCallbackInterface = instance;
            if (instance != null)
            {
                @MovementInput.started += instance.OnMovementInput;
                @MovementInput.performed += instance.OnMovementInput;
                @MovementInput.canceled += instance.OnMovementInput;
                @UpInput.started += instance.OnUpInput;
                @UpInput.performed += instance.OnUpInput;
                @UpInput.canceled += instance.OnUpInput;
                @DownInput.started += instance.OnDownInput;
                @DownInput.performed += instance.OnDownInput;
                @DownInput.canceled += instance.OnDownInput;
                @JumpInput.started += instance.OnJumpInput;
                @JumpInput.performed += instance.OnJumpInput;
                @JumpInput.canceled += instance.OnJumpInput;
                @SlashInput.started += instance.OnSlashInput;
                @SlashInput.performed += instance.OnSlashInput;
                @SlashInput.canceled += instance.OnSlashInput;
                @ProjectileInput.started += instance.OnProjectileInput;
                @ProjectileInput.performed += instance.OnProjectileInput;
                @ProjectileInput.canceled += instance.OnProjectileInput;
                @MenuInput.started += instance.OnMenuInput;
                @MenuInput.performed += instance.OnMenuInput;
                @MenuInput.canceled += instance.OnMenuInput;
            }
        }
    }
    public GameplayActions @Gameplay => new GameplayActions(this);
    public interface IGameplayActions
    {
        void OnMovementInput(InputAction.CallbackContext context);
        void OnUpInput(InputAction.CallbackContext context);
        void OnDownInput(InputAction.CallbackContext context);
        void OnJumpInput(InputAction.CallbackContext context);
        void OnSlashInput(InputAction.CallbackContext context);
        void OnProjectileInput(InputAction.CallbackContext context);
        void OnMenuInput(InputAction.CallbackContext context);
    }
}
