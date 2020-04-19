// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/PlayerControlsInput.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerControlsInput : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerControlsInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControlsInput"",
    ""maps"": [
        {
            ""name"": ""GameplayP1"",
            ""id"": ""3ce8d959-d5ce-4e71-a53a-2868b1e922e0"",
            ""actions"": [
                {
                    ""name"": ""Rotation"",
                    ""type"": ""Button"",
                    ""id"": ""929ebce6-fe4f-4b09-95cb-5d745fce23ef"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""a56f07ea-1e32-4064-9633-fba25c1d387e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""BoostOn"",
                    ""type"": ""Button"",
                    ""id"": ""e6335e9f-ac9a-4214-927f-2ca419fa69c8"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""BoostOff"",
                    ""type"": ""Button"",
                    ""id"": ""2f5c46b0-c545-409b-9a3d-83392f5fc9d5"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=1)""
                },
                {
                    ""name"": ""FlipCar"",
                    ""type"": ""Button"",
                    ""id"": ""d2ec0975-c305-4c4b-8cc5-3575f40aa1d5"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""FlipDirection"",
                    ""type"": ""Button"",
                    ""id"": ""1c6ac683-4540-4d0b-9cd4-14286f2e7c86"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""EscMenu"",
                    ""type"": ""Button"",
                    ""id"": ""560ea594-430c-473d-ae26-dcf9408c6812"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""Restart"",
                    ""type"": ""PassThrough"",
                    ""id"": ""cf26985b-8466-426d-b4d4-e6f8a95e1a48"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""AccelDecel"",
                    ""type"": ""Button"",
                    ""id"": ""f3047756-140c-40ec-a494-1638b70890ea"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""Join"",
                    ""type"": ""Button"",
                    ""id"": ""5820d82c-e7dc-45b7-a323-928ce3192c5a"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""375abce9-0f2d-4f58-b854-4a7f9e5163dd"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotation"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""dc71e91e-4262-40a2-a249-dbdff628234f"",
                    ""path"": ""<Keyboard>/t"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Rotation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""0e2acbb7-26bc-43c9-a025-810e6b42423f"",
                    ""path"": ""<Keyboard>/g"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Rotation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""e654ca0a-4ef1-48da-858c-edd64c7f34ee"",
                    ""path"": ""<Keyboard>/f"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Rotation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""26a5092a-bd77-4975-b0a8-015ae31e765c"",
                    ""path"": ""<Keyboard>/h"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Rotation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""e28ec2fc-375d-4e9b-b71f-288bd623a92b"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Rotation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e7d563e6-0af6-4c12-a2ac-d1f10b81ceeb"",
                    ""path"": ""<Keyboard>/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""97b51583-ffa1-4e75-963f-58619c674e99"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a687806d-798d-4404-989b-6b554e290d79"",
                    ""path"": ""<Keyboard>/z"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""BoostOn"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""109c9e62-2a79-49e8-96da-d81bbfeb7e13"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""BoostOn"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5b19e38f-64d0-4647-b5de-a2c0ea40538b"",
                    ""path"": ""<Keyboard>/OEM1"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""FlipCar"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""430271c3-732a-4181-9c07-022b57f3769f"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""FlipCar"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f016c910-97f9-426d-b6a1-a1be47f0b390"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""FlipDirection"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""35aab653-d98e-4640-9e78-165ee1dd0932"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""FlipDirection"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""down"",
                    ""id"": ""20acf732-456f-4083-8408-fb8f83f53109"",
                    ""path"": ""<Keyboard>/g"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""FlipDirection"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""up"",
                    ""id"": ""4c323b7d-df42-4521-a91a-15d847be52d2"",
                    ""path"": ""<Keyboard>/t"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""FlipDirection"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""a34521e6-2a0d-45fc-98fc-1950540fbc8c"",
                    ""path"": ""<Gamepad>/dpad"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""FlipDirection"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0c4f6453-4748-4250-ba28-952ea0b68bae"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""EscMenu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0dd50ec8-94f1-452a-a110-6ccb18f90090"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""EscMenu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9a915f8d-80e5-483a-ac02-c76997d7bfe9"",
                    ""path"": ""<Keyboard>/r"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Restart"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1655997b-86f8-46fb-84a5-c3e08382ffaf"",
                    ""path"": ""<Gamepad>/select"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Restart"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""46c37808-9ed2-4947-b4d5-a4bbe3492778"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""AccelDecel"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Up"",
                    ""id"": ""5d83fd8a-300e-4ccd-8a28-6ed3dbb645d6"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""AccelDecel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Down"",
                    ""id"": ""1393c6a5-550e-47dd-9520-38463d5b0c54"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""AccelDecel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""fdc4b641-fe99-4d91-b610-79a6c74cfe2d"",
                    ""path"": ""2DVector(mode=2)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""AccelDecel"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Up"",
                    ""id"": ""9b4ee5df-a954-4372-8302-945a0d6770cc"",
                    ""path"": ""<Keyboard>/t"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""AccelDecel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Down"",
                    ""id"": ""cd168d5c-3a94-40a4-b1dd-439eae5800e1"",
                    ""path"": ""<Keyboard>/g"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""AccelDecel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""c98a2155-2e30-4c46-96c2-a64f75d1c4a4"",
                    ""path"": ""<Gamepad>/dpad"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Rotation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5c8c643d-8f4a-4bd2-b581-e17629e5c2b0"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Join"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""830ffc4c-ffdd-45be-aaad-c3be930a2a74"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Join"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""856cb7fc-d5ef-402b-b3c2-501eaa3eda75"",
                    ""path"": ""<Keyboard>/slash"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""03e4f920-aeb7-425a-b309-175c7bcee22b"",
                    ""path"": ""<Keyboard>/period"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""BoostOn"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""167ed28c-df02-44a7-a1a2-b7f158c3686f"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""FlipDirection"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""down"",
                    ""id"": ""c3a96ba8-0187-4a6a-bea0-a348b399a666"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""FlipDirection"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""up"",
                    ""id"": ""9c9c0380-d579-4427-9b0c-58f3e3177498"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""FlipDirection"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""36c7e5ca-b899-4a7d-9f66-4f15e8c7e069"",
                    ""path"": ""2DVector(mode=2)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""AccelDecel"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Up"",
                    ""id"": ""e8a15516-fa6e-4991-9bc0-509f9d9906e5"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""AccelDecel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Down"",
                    ""id"": ""84ce2c21-9f94-48ac-912a-5549b86b542a"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""AccelDecel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""e65718c6-9e8f-4548-b3f8-7c4b53baa87f"",
                    ""path"": ""<Keyboard>/z"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""BoostOff"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2dd20cbe-89c0-48bb-8779-ee92a51e76dd"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""BoostOff"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4e8e2439-8802-48ef-93f5-bcf877c332e9"",
                    ""path"": ""<Keyboard>/period"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""BoostOff"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Menu"",
            ""id"": ""c4d40fa8-3056-4d3d-af87-380e28e08870"",
            ""actions"": [
                {
                    ""name"": ""EscMenu"",
                    ""type"": ""Button"",
                    ""id"": ""4e741818-035e-426d-a44d-e0184f84500b"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""8ee44415-4641-4d94-9d75-d62fbf3fcdb7"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""EscMenu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d590f3b5-63cb-4138-a9b3-59b179deb02b"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""EscMenu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard"",
            ""bindingGroup"": ""Keyboard"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
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
                    ""isOptional"": true,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<DualShockGamepad>"",
                    ""isOptional"": true,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<XInputController>"",
                    ""isOptional"": true,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // GameplayP1
        m_GameplayP1 = asset.FindActionMap("GameplayP1", throwIfNotFound: true);
        m_GameplayP1_Rotation = m_GameplayP1.FindAction("Rotation", throwIfNotFound: true);
        m_GameplayP1_Jump = m_GameplayP1.FindAction("Jump", throwIfNotFound: true);
        m_GameplayP1_BoostOn = m_GameplayP1.FindAction("BoostOn", throwIfNotFound: true);
        m_GameplayP1_BoostOff = m_GameplayP1.FindAction("BoostOff", throwIfNotFound: true);
        m_GameplayP1_FlipCar = m_GameplayP1.FindAction("FlipCar", throwIfNotFound: true);
        m_GameplayP1_FlipDirection = m_GameplayP1.FindAction("FlipDirection", throwIfNotFound: true);
        m_GameplayP1_EscMenu = m_GameplayP1.FindAction("EscMenu", throwIfNotFound: true);
        m_GameplayP1_Restart = m_GameplayP1.FindAction("Restart", throwIfNotFound: true);
        m_GameplayP1_AccelDecel = m_GameplayP1.FindAction("AccelDecel", throwIfNotFound: true);
        m_GameplayP1_Join = m_GameplayP1.FindAction("Join", throwIfNotFound: true);
        // Menu
        m_Menu = asset.FindActionMap("Menu", throwIfNotFound: true);
        m_Menu_EscMenu = m_Menu.FindAction("EscMenu", throwIfNotFound: true);
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

    // GameplayP1
    private readonly InputActionMap m_GameplayP1;
    private IGameplayP1Actions m_GameplayP1ActionsCallbackInterface;
    private readonly InputAction m_GameplayP1_Rotation;
    private readonly InputAction m_GameplayP1_Jump;
    private readonly InputAction m_GameplayP1_BoostOn;
    private readonly InputAction m_GameplayP1_BoostOff;
    private readonly InputAction m_GameplayP1_FlipCar;
    private readonly InputAction m_GameplayP1_FlipDirection;
    private readonly InputAction m_GameplayP1_EscMenu;
    private readonly InputAction m_GameplayP1_Restart;
    private readonly InputAction m_GameplayP1_AccelDecel;
    private readonly InputAction m_GameplayP1_Join;
    public struct GameplayP1Actions
    {
        private @PlayerControlsInput m_Wrapper;
        public GameplayP1Actions(@PlayerControlsInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Rotation => m_Wrapper.m_GameplayP1_Rotation;
        public InputAction @Jump => m_Wrapper.m_GameplayP1_Jump;
        public InputAction @BoostOn => m_Wrapper.m_GameplayP1_BoostOn;
        public InputAction @BoostOff => m_Wrapper.m_GameplayP1_BoostOff;
        public InputAction @FlipCar => m_Wrapper.m_GameplayP1_FlipCar;
        public InputAction @FlipDirection => m_Wrapper.m_GameplayP1_FlipDirection;
        public InputAction @EscMenu => m_Wrapper.m_GameplayP1_EscMenu;
        public InputAction @Restart => m_Wrapper.m_GameplayP1_Restart;
        public InputAction @AccelDecel => m_Wrapper.m_GameplayP1_AccelDecel;
        public InputAction @Join => m_Wrapper.m_GameplayP1_Join;
        public InputActionMap Get() { return m_Wrapper.m_GameplayP1; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GameplayP1Actions set) { return set.Get(); }
        public void SetCallbacks(IGameplayP1Actions instance)
        {
            if (m_Wrapper.m_GameplayP1ActionsCallbackInterface != null)
            {
                @Rotation.started -= m_Wrapper.m_GameplayP1ActionsCallbackInterface.OnRotation;
                @Rotation.performed -= m_Wrapper.m_GameplayP1ActionsCallbackInterface.OnRotation;
                @Rotation.canceled -= m_Wrapper.m_GameplayP1ActionsCallbackInterface.OnRotation;
                @Jump.started -= m_Wrapper.m_GameplayP1ActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_GameplayP1ActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_GameplayP1ActionsCallbackInterface.OnJump;
                @BoostOn.started -= m_Wrapper.m_GameplayP1ActionsCallbackInterface.OnBoostOn;
                @BoostOn.performed -= m_Wrapper.m_GameplayP1ActionsCallbackInterface.OnBoostOn;
                @BoostOn.canceled -= m_Wrapper.m_GameplayP1ActionsCallbackInterface.OnBoostOn;
                @BoostOff.started -= m_Wrapper.m_GameplayP1ActionsCallbackInterface.OnBoostOff;
                @BoostOff.performed -= m_Wrapper.m_GameplayP1ActionsCallbackInterface.OnBoostOff;
                @BoostOff.canceled -= m_Wrapper.m_GameplayP1ActionsCallbackInterface.OnBoostOff;
                @FlipCar.started -= m_Wrapper.m_GameplayP1ActionsCallbackInterface.OnFlipCar;
                @FlipCar.performed -= m_Wrapper.m_GameplayP1ActionsCallbackInterface.OnFlipCar;
                @FlipCar.canceled -= m_Wrapper.m_GameplayP1ActionsCallbackInterface.OnFlipCar;
                @FlipDirection.started -= m_Wrapper.m_GameplayP1ActionsCallbackInterface.OnFlipDirection;
                @FlipDirection.performed -= m_Wrapper.m_GameplayP1ActionsCallbackInterface.OnFlipDirection;
                @FlipDirection.canceled -= m_Wrapper.m_GameplayP1ActionsCallbackInterface.OnFlipDirection;
                @EscMenu.started -= m_Wrapper.m_GameplayP1ActionsCallbackInterface.OnEscMenu;
                @EscMenu.performed -= m_Wrapper.m_GameplayP1ActionsCallbackInterface.OnEscMenu;
                @EscMenu.canceled -= m_Wrapper.m_GameplayP1ActionsCallbackInterface.OnEscMenu;
                @Restart.started -= m_Wrapper.m_GameplayP1ActionsCallbackInterface.OnRestart;
                @Restart.performed -= m_Wrapper.m_GameplayP1ActionsCallbackInterface.OnRestart;
                @Restart.canceled -= m_Wrapper.m_GameplayP1ActionsCallbackInterface.OnRestart;
                @AccelDecel.started -= m_Wrapper.m_GameplayP1ActionsCallbackInterface.OnAccelDecel;
                @AccelDecel.performed -= m_Wrapper.m_GameplayP1ActionsCallbackInterface.OnAccelDecel;
                @AccelDecel.canceled -= m_Wrapper.m_GameplayP1ActionsCallbackInterface.OnAccelDecel;
                @Join.started -= m_Wrapper.m_GameplayP1ActionsCallbackInterface.OnJoin;
                @Join.performed -= m_Wrapper.m_GameplayP1ActionsCallbackInterface.OnJoin;
                @Join.canceled -= m_Wrapper.m_GameplayP1ActionsCallbackInterface.OnJoin;
            }
            m_Wrapper.m_GameplayP1ActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Rotation.started += instance.OnRotation;
                @Rotation.performed += instance.OnRotation;
                @Rotation.canceled += instance.OnRotation;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @BoostOn.started += instance.OnBoostOn;
                @BoostOn.performed += instance.OnBoostOn;
                @BoostOn.canceled += instance.OnBoostOn;
                @BoostOff.started += instance.OnBoostOff;
                @BoostOff.performed += instance.OnBoostOff;
                @BoostOff.canceled += instance.OnBoostOff;
                @FlipCar.started += instance.OnFlipCar;
                @FlipCar.performed += instance.OnFlipCar;
                @FlipCar.canceled += instance.OnFlipCar;
                @FlipDirection.started += instance.OnFlipDirection;
                @FlipDirection.performed += instance.OnFlipDirection;
                @FlipDirection.canceled += instance.OnFlipDirection;
                @EscMenu.started += instance.OnEscMenu;
                @EscMenu.performed += instance.OnEscMenu;
                @EscMenu.canceled += instance.OnEscMenu;
                @Restart.started += instance.OnRestart;
                @Restart.performed += instance.OnRestart;
                @Restart.canceled += instance.OnRestart;
                @AccelDecel.started += instance.OnAccelDecel;
                @AccelDecel.performed += instance.OnAccelDecel;
                @AccelDecel.canceled += instance.OnAccelDecel;
                @Join.started += instance.OnJoin;
                @Join.performed += instance.OnJoin;
                @Join.canceled += instance.OnJoin;
            }
        }
    }
    public GameplayP1Actions @GameplayP1 => new GameplayP1Actions(this);

    // Menu
    private readonly InputActionMap m_Menu;
    private IMenuActions m_MenuActionsCallbackInterface;
    private readonly InputAction m_Menu_EscMenu;
    public struct MenuActions
    {
        private @PlayerControlsInput m_Wrapper;
        public MenuActions(@PlayerControlsInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @EscMenu => m_Wrapper.m_Menu_EscMenu;
        public InputActionMap Get() { return m_Wrapper.m_Menu; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MenuActions set) { return set.Get(); }
        public void SetCallbacks(IMenuActions instance)
        {
            if (m_Wrapper.m_MenuActionsCallbackInterface != null)
            {
                @EscMenu.started -= m_Wrapper.m_MenuActionsCallbackInterface.OnEscMenu;
                @EscMenu.performed -= m_Wrapper.m_MenuActionsCallbackInterface.OnEscMenu;
                @EscMenu.canceled -= m_Wrapper.m_MenuActionsCallbackInterface.OnEscMenu;
            }
            m_Wrapper.m_MenuActionsCallbackInterface = instance;
            if (instance != null)
            {
                @EscMenu.started += instance.OnEscMenu;
                @EscMenu.performed += instance.OnEscMenu;
                @EscMenu.canceled += instance.OnEscMenu;
            }
        }
    }
    public MenuActions @Menu => new MenuActions(this);
    private int m_KeyboardSchemeIndex = -1;
    public InputControlScheme KeyboardScheme
    {
        get
        {
            if (m_KeyboardSchemeIndex == -1) m_KeyboardSchemeIndex = asset.FindControlSchemeIndex("Keyboard");
            return asset.controlSchemes[m_KeyboardSchemeIndex];
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
    public interface IGameplayP1Actions
    {
        void OnRotation(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnBoostOn(InputAction.CallbackContext context);
        void OnBoostOff(InputAction.CallbackContext context);
        void OnFlipCar(InputAction.CallbackContext context);
        void OnFlipDirection(InputAction.CallbackContext context);
        void OnEscMenu(InputAction.CallbackContext context);
        void OnRestart(InputAction.CallbackContext context);
        void OnAccelDecel(InputAction.CallbackContext context);
        void OnJoin(InputAction.CallbackContext context);
    }
    public interface IMenuActions
    {
        void OnEscMenu(InputAction.CallbackContext context);
    }
}
