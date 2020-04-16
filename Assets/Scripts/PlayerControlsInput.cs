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
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""a56f07ea-1e32-4064-9633-fba25c1d387e"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""Boost"",
                    ""type"": ""Button"",
                    ""id"": ""e6335e9f-ac9a-4214-927f-2ca419fa69c8"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": ""Press""
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
                    ""type"": ""Button"",
                    ""id"": ""cf26985b-8466-426d-b4d4-e6f8a95e1a48"",
                    ""expectedControlType"": """",
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
                    ""action"": ""Boost"",
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
                    ""action"": ""Boost"",
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
                }
            ]
        },
        {
            ""name"": ""GameplayP2"",
            ""id"": ""52aeeaec-da78-475b-ba86-b90b2a67ec67"",
            ""actions"": [
                {
                    ""name"": ""Rotation"",
                    ""type"": ""Button"",
                    ""id"": ""5760f431-a687-4f55-b290-dfcef3821fef"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""aafc585d-42ea-4981-9631-061f5f89fa33"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""Boost"",
                    ""type"": ""Button"",
                    ""id"": ""0df9fb35-9e7b-445f-a3fa-bba97f25722f"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""FlipCar"",
                    ""type"": ""Button"",
                    ""id"": ""bd5a2949-fc88-4cb1-b9ed-35d85d6fcd0f"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""FlipDirection"",
                    ""type"": ""Button"",
                    ""id"": ""fc286558-3546-4231-bfe3-45c241c69f65"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""EscMenu"",
                    ""type"": ""Button"",
                    ""id"": ""93c3016a-ebdd-4db9-b142-af948b737152"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""Restart"",
                    ""type"": ""Button"",
                    ""id"": ""1c9cdad7-92e7-4483-b11a-00194214feb0"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""AccelDecel"",
                    ""type"": ""Button"",
                    ""id"": ""d49152f8-e2f6-4b7b-8062-b86c439c0fbe"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": ""Press""
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""cb53b498-c868-4a0b-9701-f232bc1dec66"",
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
                    ""id"": ""3df9c1e0-c1e0-4d38-abee-6f1c5e209f4d"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Rotation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""97924afb-e4e4-4883-b694-db53814caf49"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Rotation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""f49cece6-669e-4c57-b107-b4d70938fd40"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Rotation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""3ee19779-6d93-44f3-a072-2a544372fa88"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Rotation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""a0f7b738-b655-4fe4-9ec3-3a41cd2574e0"",
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
                    ""id"": ""7c9f2b19-d6de-4fad-bbf1-7a33b6234f01"",
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
                    ""id"": ""a6914e3e-f637-4a55-8e9c-2bcc1a6e34b4"",
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
                    ""id"": ""53a5147f-e631-4a92-a3c6-7b6fc524f59a"",
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
                    ""id"": ""71cab9fe-68ed-436f-bf11-a16bff61c4af"",
                    ""path"": ""<Keyboard>/period"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Boost"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3d3cc476-e13b-458e-bb09-ee2ab372ff89"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Boost"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""602aba65-dbf7-4b5b-86b5-7e730f146167"",
                    ""path"": ""<Keyboard>/comma"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""FlipCar"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9b98579e-ad7f-4c87-87fb-d9a8f98b4b8d"",
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
                    ""id"": ""7b48c79e-ed42-4ae2-bf38-89db17ba786d"",
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
                    ""id"": ""c88dbfc9-7fa5-4643-ad0f-95802ebb146a"",
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
                    ""id"": ""06299edc-dfe9-43f2-bf1a-cc3c08f468c8"",
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
                    ""id"": ""02fa19a1-06a5-48d8-8680-baf152b1f9b2"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""FlipDirection"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""3dc5ebc5-a7f2-4252-b0c8-eb9ffda25a00"",
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
                    ""id"": ""9ccce97e-1f2a-4470-98d1-d98c67d1e14a"",
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
                    ""id"": ""058aa3e5-b62e-4d26-a8ef-47c64a2ee287"",
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
                    ""id"": ""0f36861f-e26c-497b-9f19-c30f9d2cf87c"",
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
                    ""id"": ""0b071ff7-2d4a-435d-a4b3-4b7519066139"",
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
                    ""id"": ""9e0a4178-e03a-4363-a35b-96f2c8d56643"",
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
                    ""id"": ""a119d360-531c-4f6c-8495-d4731efe3f1c"",
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
                    ""id"": ""ae106e3c-542f-4f3a-aff1-289e5e813ea9"",
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
                    ""id"": ""46f6fdd1-7f91-4eb9-a991-b571fefaa9bc"",
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
                    ""id"": ""f7e3d31c-e20f-4d84-be67-6dfd48c4c4e3"",
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
                    ""id"": ""5a7de430-be7f-4c08-8a54-395c29753423"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""AccelDecel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
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
        m_GameplayP1_Boost = m_GameplayP1.FindAction("Boost", throwIfNotFound: true);
        m_GameplayP1_FlipCar = m_GameplayP1.FindAction("FlipCar", throwIfNotFound: true);
        m_GameplayP1_FlipDirection = m_GameplayP1.FindAction("FlipDirection", throwIfNotFound: true);
        m_GameplayP1_EscMenu = m_GameplayP1.FindAction("EscMenu", throwIfNotFound: true);
        m_GameplayP1_Restart = m_GameplayP1.FindAction("Restart", throwIfNotFound: true);
        m_GameplayP1_AccelDecel = m_GameplayP1.FindAction("AccelDecel", throwIfNotFound: true);
        // GameplayP2
        m_GameplayP2 = asset.FindActionMap("GameplayP2", throwIfNotFound: true);
        m_GameplayP2_Rotation = m_GameplayP2.FindAction("Rotation", throwIfNotFound: true);
        m_GameplayP2_Jump = m_GameplayP2.FindAction("Jump", throwIfNotFound: true);
        m_GameplayP2_Boost = m_GameplayP2.FindAction("Boost", throwIfNotFound: true);
        m_GameplayP2_FlipCar = m_GameplayP2.FindAction("FlipCar", throwIfNotFound: true);
        m_GameplayP2_FlipDirection = m_GameplayP2.FindAction("FlipDirection", throwIfNotFound: true);
        m_GameplayP2_EscMenu = m_GameplayP2.FindAction("EscMenu", throwIfNotFound: true);
        m_GameplayP2_Restart = m_GameplayP2.FindAction("Restart", throwIfNotFound: true);
        m_GameplayP2_AccelDecel = m_GameplayP2.FindAction("AccelDecel", throwIfNotFound: true);
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
    private readonly InputAction m_GameplayP1_Boost;
    private readonly InputAction m_GameplayP1_FlipCar;
    private readonly InputAction m_GameplayP1_FlipDirection;
    private readonly InputAction m_GameplayP1_EscMenu;
    private readonly InputAction m_GameplayP1_Restart;
    private readonly InputAction m_GameplayP1_AccelDecel;
    public struct GameplayP1Actions
    {
        private @PlayerControlsInput m_Wrapper;
        public GameplayP1Actions(@PlayerControlsInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Rotation => m_Wrapper.m_GameplayP1_Rotation;
        public InputAction @Jump => m_Wrapper.m_GameplayP1_Jump;
        public InputAction @Boost => m_Wrapper.m_GameplayP1_Boost;
        public InputAction @FlipCar => m_Wrapper.m_GameplayP1_FlipCar;
        public InputAction @FlipDirection => m_Wrapper.m_GameplayP1_FlipDirection;
        public InputAction @EscMenu => m_Wrapper.m_GameplayP1_EscMenu;
        public InputAction @Restart => m_Wrapper.m_GameplayP1_Restart;
        public InputAction @AccelDecel => m_Wrapper.m_GameplayP1_AccelDecel;
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
                @Boost.started -= m_Wrapper.m_GameplayP1ActionsCallbackInterface.OnBoost;
                @Boost.performed -= m_Wrapper.m_GameplayP1ActionsCallbackInterface.OnBoost;
                @Boost.canceled -= m_Wrapper.m_GameplayP1ActionsCallbackInterface.OnBoost;
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
                @Boost.started += instance.OnBoost;
                @Boost.performed += instance.OnBoost;
                @Boost.canceled += instance.OnBoost;
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
            }
        }
    }
    public GameplayP1Actions @GameplayP1 => new GameplayP1Actions(this);

    // GameplayP2
    private readonly InputActionMap m_GameplayP2;
    private IGameplayP2Actions m_GameplayP2ActionsCallbackInterface;
    private readonly InputAction m_GameplayP2_Rotation;
    private readonly InputAction m_GameplayP2_Jump;
    private readonly InputAction m_GameplayP2_Boost;
    private readonly InputAction m_GameplayP2_FlipCar;
    private readonly InputAction m_GameplayP2_FlipDirection;
    private readonly InputAction m_GameplayP2_EscMenu;
    private readonly InputAction m_GameplayP2_Restart;
    private readonly InputAction m_GameplayP2_AccelDecel;
    public struct GameplayP2Actions
    {
        private @PlayerControlsInput m_Wrapper;
        public GameplayP2Actions(@PlayerControlsInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Rotation => m_Wrapper.m_GameplayP2_Rotation;
        public InputAction @Jump => m_Wrapper.m_GameplayP2_Jump;
        public InputAction @Boost => m_Wrapper.m_GameplayP2_Boost;
        public InputAction @FlipCar => m_Wrapper.m_GameplayP2_FlipCar;
        public InputAction @FlipDirection => m_Wrapper.m_GameplayP2_FlipDirection;
        public InputAction @EscMenu => m_Wrapper.m_GameplayP2_EscMenu;
        public InputAction @Restart => m_Wrapper.m_GameplayP2_Restart;
        public InputAction @AccelDecel => m_Wrapper.m_GameplayP2_AccelDecel;
        public InputActionMap Get() { return m_Wrapper.m_GameplayP2; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GameplayP2Actions set) { return set.Get(); }
        public void SetCallbacks(IGameplayP2Actions instance)
        {
            if (m_Wrapper.m_GameplayP2ActionsCallbackInterface != null)
            {
                @Rotation.started -= m_Wrapper.m_GameplayP2ActionsCallbackInterface.OnRotation;
                @Rotation.performed -= m_Wrapper.m_GameplayP2ActionsCallbackInterface.OnRotation;
                @Rotation.canceled -= m_Wrapper.m_GameplayP2ActionsCallbackInterface.OnRotation;
                @Jump.started -= m_Wrapper.m_GameplayP2ActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_GameplayP2ActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_GameplayP2ActionsCallbackInterface.OnJump;
                @Boost.started -= m_Wrapper.m_GameplayP2ActionsCallbackInterface.OnBoost;
                @Boost.performed -= m_Wrapper.m_GameplayP2ActionsCallbackInterface.OnBoost;
                @Boost.canceled -= m_Wrapper.m_GameplayP2ActionsCallbackInterface.OnBoost;
                @FlipCar.started -= m_Wrapper.m_GameplayP2ActionsCallbackInterface.OnFlipCar;
                @FlipCar.performed -= m_Wrapper.m_GameplayP2ActionsCallbackInterface.OnFlipCar;
                @FlipCar.canceled -= m_Wrapper.m_GameplayP2ActionsCallbackInterface.OnFlipCar;
                @FlipDirection.started -= m_Wrapper.m_GameplayP2ActionsCallbackInterface.OnFlipDirection;
                @FlipDirection.performed -= m_Wrapper.m_GameplayP2ActionsCallbackInterface.OnFlipDirection;
                @FlipDirection.canceled -= m_Wrapper.m_GameplayP2ActionsCallbackInterface.OnFlipDirection;
                @EscMenu.started -= m_Wrapper.m_GameplayP2ActionsCallbackInterface.OnEscMenu;
                @EscMenu.performed -= m_Wrapper.m_GameplayP2ActionsCallbackInterface.OnEscMenu;
                @EscMenu.canceled -= m_Wrapper.m_GameplayP2ActionsCallbackInterface.OnEscMenu;
                @Restart.started -= m_Wrapper.m_GameplayP2ActionsCallbackInterface.OnRestart;
                @Restart.performed -= m_Wrapper.m_GameplayP2ActionsCallbackInterface.OnRestart;
                @Restart.canceled -= m_Wrapper.m_GameplayP2ActionsCallbackInterface.OnRestart;
                @AccelDecel.started -= m_Wrapper.m_GameplayP2ActionsCallbackInterface.OnAccelDecel;
                @AccelDecel.performed -= m_Wrapper.m_GameplayP2ActionsCallbackInterface.OnAccelDecel;
                @AccelDecel.canceled -= m_Wrapper.m_GameplayP2ActionsCallbackInterface.OnAccelDecel;
            }
            m_Wrapper.m_GameplayP2ActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Rotation.started += instance.OnRotation;
                @Rotation.performed += instance.OnRotation;
                @Rotation.canceled += instance.OnRotation;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Boost.started += instance.OnBoost;
                @Boost.performed += instance.OnBoost;
                @Boost.canceled += instance.OnBoost;
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
            }
        }
    }
    public GameplayP2Actions @GameplayP2 => new GameplayP2Actions(this);

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
        void OnBoost(InputAction.CallbackContext context);
        void OnFlipCar(InputAction.CallbackContext context);
        void OnFlipDirection(InputAction.CallbackContext context);
        void OnEscMenu(InputAction.CallbackContext context);
        void OnRestart(InputAction.CallbackContext context);
        void OnAccelDecel(InputAction.CallbackContext context);
    }
    public interface IGameplayP2Actions
    {
        void OnRotation(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnBoost(InputAction.CallbackContext context);
        void OnFlipCar(InputAction.CallbackContext context);
        void OnFlipDirection(InputAction.CallbackContext context);
        void OnEscMenu(InputAction.CallbackContext context);
        void OnRestart(InputAction.CallbackContext context);
        void OnAccelDecel(InputAction.CallbackContext context);
    }
    public interface IMenuActions
    {
        void OnEscMenu(InputAction.CallbackContext context);
    }
}
