// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/PlayerInput.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerInput : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInput"",
    ""maps"": [
        {
            ""name"": ""GameplayP1"",
            ""id"": ""3ce8d959-d5ce-4e71-a53a-2868b1e922e0"",
            ""actions"": [
                {
                    ""name"": ""CarMovement"",
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
                    ""name"": ""Join"",
                    ""type"": ""Button"",
                    ""id"": ""efad0daf-0459-4e18-ae56-89a6d986e618"",
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
                    ""action"": ""CarMovement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""dc71e91e-4262-40a2-a249-dbdff628234f"",
                    ""path"": ""<Keyboard>/t"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CarMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""0e2acbb7-26bc-43c9-a025-810e6b42423f"",
                    ""path"": ""<Keyboard>/g"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CarMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""e654ca0a-4ef1-48da-858c-edd64c7f34ee"",
                    ""path"": ""<Keyboard>/f"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CarMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""26a5092a-bd77-4975-b0a8-015ae31e765c"",
                    ""path"": ""<Keyboard>/h"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CarMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""a87a2d41-b81d-4a3e-b55e-77749f4308a8"",
                    ""path"": ""2DVector(mode=2)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CarMovement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""71e4a4c3-4a5e-4e4b-9af5-cb4a0e8d326c"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CarMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""8a948974-b8a9-4794-8b69-654dceff2eb5"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CarMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""3499d8ce-dcbe-443e-877f-cf5fa1cf67b4"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CarMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""b1e7819f-f0e2-4639-8c48-4659ab775327"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CarMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""4adda522-02cf-42d4-9dcf-6b6bfdc2e060"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CarMovement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""763847fe-77d7-4bd0-805d-7c9fb5b7ed26"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CarMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""a238571e-6e1f-4b6e-aee3-6f991859806a"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CarMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""da8292e9-7f9d-4f92-9270-d91ff774b21a"",
                    ""path"": ""<Gamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CarMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""5da4a421-61c9-4278-adbc-69fb2b51e7ad"",
                    ""path"": ""<Gamepad>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CarMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""e7d563e6-0af6-4c12-a2ac-d1f10b81ceeb"",
                    ""path"": ""<Keyboard>/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b625c5d1-c5e6-4a38-88e8-a789afb96cbe"",
                    ""path"": ""<DualShockGamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
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
                    ""groups"": """",
                    ""action"": ""Boost"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a37c56cb-c834-4c4a-a91b-5091181d83be"",
                    ""path"": ""<DualShockGamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
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
                    ""groups"": """",
                    ""action"": ""FlipCar"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""805388f1-fa6c-4b02-a609-0886f4c9bd0f"",
                    ""path"": ""<DualShockGamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""FlipCar"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""768b7ad9-b238-4f6e-8f51-6acf0afe8376"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""FlipDirection"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""256fe567-78ce-4ee3-9d99-1257b53af8e8"",
                    ""path"": ""<Keyboard>/t"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""FlipDirection"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""c81339d4-edfb-443c-8773-08c3031a1fde"",
                    ""path"": ""<Keyboard>/g"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""FlipDirection"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""30f16e6f-1d67-46f4-80ec-1ce8e073e014"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""FlipDirection"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""97f52aea-9064-472e-8cd3-5ec867eec5b5"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""FlipDirection"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""c22646d8-63d9-45bf-88e9-24a0310f2a6e"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""FlipDirection"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""6f5e10ba-4add-4fb2-816c-4db677ca66e8"",
                    ""path"": ""<DualShockGamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""FlipDirection"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""9e5f11cd-881e-4c4e-b56d-18c1bdbd1fda"",
                    ""path"": ""<DualShockGamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""FlipDirection"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""fe38e0a7-19e2-4732-9b31-19bd3b12aae0"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""FlipDirection"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""4a3c1af3-0047-45d8-9ffe-01979a2ad5fd"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""FlipDirection"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""3cedc11f-db8a-4467-a6c7-a246718621b5"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""FlipDirection"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""05778d85-5f78-45f5-bfaa-287dfdab5afd"",
                    ""path"": ""<Gamepad>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""FlipDirection"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""bc2b85f5-02ee-4e6f-bf69-be293deb6a18"",
                    ""path"": ""<Gamepad>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""FlipDirection"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""a642f4d3-b7a1-41eb-a603-d1f26a044f92"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""FlipDirection"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""79a24cc7-6e4e-4fd6-a07d-89ae69e4aee6"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""FlipDirection"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""656544b1-8218-4cac-b8d6-1e7010b4f9f2"",
                    ""path"": ""<Keyboard>/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Join"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""be91a3cf-ffdb-4d5d-aa61-e24f35c73f89"",
                    ""path"": ""<DualShockGamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Join"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""GameplayP2"",
            ""id"": ""fb280655-1f8a-4f7a-8aa4-af601de8bc16"",
            ""actions"": [
                {
                    ""name"": ""CarMovement"",
                    ""type"": ""Button"",
                    ""id"": ""a8320d1c-e366-40f5-9297-db31a99da0f0"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""c61db5a6-1e97-4dd3-bd1c-68afa16906a1"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""Boost"",
                    ""type"": ""Button"",
                    ""id"": ""f87bf7ad-03a5-4e30-85a4-66c2ffacf9b5"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""FlipCar"",
                    ""type"": ""Button"",
                    ""id"": ""b3897366-c023-4090-acc3-8f8f4b2393e5"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""FlipDirection"",
                    ""type"": ""Button"",
                    ""id"": ""29fa97cf-9d53-45a0-9cb8-5197d75109b9"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Join"",
                    ""type"": ""Button"",
                    ""id"": ""3ac76b2e-f13d-40c0-a5c5-1116173f98ec"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""f721ebb1-b904-4fef-88d5-2f5c8aeb9b58"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CarMovement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""b6eeb455-d5df-4f6f-8bb9-8264cd9c671f"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CarMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""2866f6e6-5c09-49fa-88e7-97c74f95415d"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CarMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""0fc2fc61-71fa-4eee-bb89-d9d12e55cd68"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CarMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""b44876c9-6786-44eb-b3a7-5071474a0597"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CarMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""17f38cb9-bfc5-45cd-9f33-c0c920d6fae5"",
                    ""path"": ""2DVector(mode=2)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CarMovement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""ee943cb6-c6e8-4d6d-839e-ed180006bf82"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CarMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""fea3e256-5e17-47eb-85b5-e781b71e06eb"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CarMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""14ac7e25-4e57-46ba-a8a0-2e1bae3f52c7"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CarMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""c076763a-0ebf-41f4-a426-c419d96c48d7"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CarMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""96132814-0b0c-4bba-8b09-347f26dafc56"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CarMovement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""3e508254-d819-4bf8-8c18-c217bfb71010"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CarMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""e3ac61b0-d3a5-443c-98bc-640b8c030a6e"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CarMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""379583e1-1bc8-42b2-b000-e01a06189613"",
                    ""path"": ""<Gamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CarMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""bb807bc3-2fce-42a3-ae3b-ebd09179fda8"",
                    ""path"": ""<Gamepad>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CarMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""a8e72008-5ae1-4ac8-a1b0-56e994137862"",
                    ""path"": ""<Keyboard>/slash"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d234e931-8e90-4109-9efe-a48659f778fb"",
                    ""path"": ""<DualShockGamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0cd18902-b7d8-4703-9cf9-6d51a2a8a0ba"",
                    ""path"": ""<Keyboard>/period"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Boost"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7beab769-3a5c-4e93-8386-be7be4aabca2"",
                    ""path"": ""<DualShockGamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Boost"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""665e2e4f-0999-4023-b1b1-dfe0e8f83bd7"",
                    ""path"": ""<Keyboard>/comma"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""FlipCar"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""89b855c3-cc1c-41e1-822b-3c445ddea32d"",
                    ""path"": ""<DualShockGamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""FlipCar"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""6da3b4de-528c-465a-8a4a-233fe0aaa6d9"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""FlipDirection"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""ca215453-342a-4a7b-affc-a23411d38cf0"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""FlipDirection"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""51b0af1c-0ca5-4dff-8338-9584c83f34b9"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""FlipDirection"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""5c78aa4f-e569-41fc-a701-bcaf3dc759b3"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""FlipDirection"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""65fff14b-af11-44bb-b057-924380cde513"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""FlipDirection"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""18e51075-0ac5-4021-b3cc-bb5c16f02fc8"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""FlipDirection"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""50f7d5b7-fb63-47fd-a9bf-a02c93ca62a7"",
                    ""path"": ""<DualShockGamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""FlipDirection"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""604a0be4-147b-4ff6-863a-d5bfb92ebcc3"",
                    ""path"": ""<DualShockGamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""FlipDirection"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""a31b88aa-4844-4569-882b-bdc1a8332aec"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""FlipDirection"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""d218c61e-afc1-4fa9-942d-3544262d2f72"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""FlipDirection"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""1da148bd-0330-4548-8d24-3d0ccadd7ff9"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""FlipDirection"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""a31d2f36-e1a5-4fc2-bc83-d7c8567c34d6"",
                    ""path"": ""<Gamepad>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""FlipDirection"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""c2681582-ebd3-400b-99f6-70e02ae5866f"",
                    ""path"": ""<Gamepad>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""FlipDirection"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""6137fa4d-c441-4680-9aab-745f829808a5"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""FlipDirection"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""6b6acd0b-aa10-4a99-b861-b6cb8923a229"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""FlipDirection"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""0de8fa61-1a27-460d-a17c-ea760e9a7a2a"",
                    ""path"": ""<Keyboard>/slash"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Join"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4b418e4b-7e85-4c52-848d-cf9498a35b02"",
                    ""path"": ""<DualShockGamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Join"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // GameplayP1
        m_GameplayP1 = asset.FindActionMap("GameplayP1", throwIfNotFound: true);
        m_GameplayP1_CarMovement = m_GameplayP1.FindAction("CarMovement", throwIfNotFound: true);
        m_GameplayP1_Jump = m_GameplayP1.FindAction("Jump", throwIfNotFound: true);
        m_GameplayP1_Boost = m_GameplayP1.FindAction("Boost", throwIfNotFound: true);
        m_GameplayP1_FlipCar = m_GameplayP1.FindAction("FlipCar", throwIfNotFound: true);
        m_GameplayP1_FlipDirection = m_GameplayP1.FindAction("FlipDirection", throwIfNotFound: true);
        m_GameplayP1_Join = m_GameplayP1.FindAction("Join", throwIfNotFound: true);
        // GameplayP2
        m_GameplayP2 = asset.FindActionMap("GameplayP2", throwIfNotFound: true);
        m_GameplayP2_CarMovement = m_GameplayP2.FindAction("CarMovement", throwIfNotFound: true);
        m_GameplayP2_Jump = m_GameplayP2.FindAction("Jump", throwIfNotFound: true);
        m_GameplayP2_Boost = m_GameplayP2.FindAction("Boost", throwIfNotFound: true);
        m_GameplayP2_FlipCar = m_GameplayP2.FindAction("FlipCar", throwIfNotFound: true);
        m_GameplayP2_FlipDirection = m_GameplayP2.FindAction("FlipDirection", throwIfNotFound: true);
        m_GameplayP2_Join = m_GameplayP2.FindAction("Join", throwIfNotFound: true);
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
    private readonly InputAction m_GameplayP1_CarMovement;
    private readonly InputAction m_GameplayP1_Jump;
    private readonly InputAction m_GameplayP1_Boost;
    private readonly InputAction m_GameplayP1_FlipCar;
    private readonly InputAction m_GameplayP1_FlipDirection;
    private readonly InputAction m_GameplayP1_Join;
    public struct GameplayP1Actions
    {
        private @PlayerInput m_Wrapper;
        public GameplayP1Actions(@PlayerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @CarMovement => m_Wrapper.m_GameplayP1_CarMovement;
        public InputAction @Jump => m_Wrapper.m_GameplayP1_Jump;
        public InputAction @Boost => m_Wrapper.m_GameplayP1_Boost;
        public InputAction @FlipCar => m_Wrapper.m_GameplayP1_FlipCar;
        public InputAction @FlipDirection => m_Wrapper.m_GameplayP1_FlipDirection;
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
                @CarMovement.started -= m_Wrapper.m_GameplayP1ActionsCallbackInterface.OnCarMovement;
                @CarMovement.performed -= m_Wrapper.m_GameplayP1ActionsCallbackInterface.OnCarMovement;
                @CarMovement.canceled -= m_Wrapper.m_GameplayP1ActionsCallbackInterface.OnCarMovement;
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
                @Join.started -= m_Wrapper.m_GameplayP1ActionsCallbackInterface.OnJoin;
                @Join.performed -= m_Wrapper.m_GameplayP1ActionsCallbackInterface.OnJoin;
                @Join.canceled -= m_Wrapper.m_GameplayP1ActionsCallbackInterface.OnJoin;
            }
            m_Wrapper.m_GameplayP1ActionsCallbackInterface = instance;
            if (instance != null)
            {
                @CarMovement.started += instance.OnCarMovement;
                @CarMovement.performed += instance.OnCarMovement;
                @CarMovement.canceled += instance.OnCarMovement;
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
                @Join.started += instance.OnJoin;
                @Join.performed += instance.OnJoin;
                @Join.canceled += instance.OnJoin;
            }
        }
    }
    public GameplayP1Actions @GameplayP1 => new GameplayP1Actions(this);

    // GameplayP2
    private readonly InputActionMap m_GameplayP2;
    private IGameplayP2Actions m_GameplayP2ActionsCallbackInterface;
    private readonly InputAction m_GameplayP2_CarMovement;
    private readonly InputAction m_GameplayP2_Jump;
    private readonly InputAction m_GameplayP2_Boost;
    private readonly InputAction m_GameplayP2_FlipCar;
    private readonly InputAction m_GameplayP2_FlipDirection;
    private readonly InputAction m_GameplayP2_Join;
    public struct GameplayP2Actions
    {
        private @PlayerInput m_Wrapper;
        public GameplayP2Actions(@PlayerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @CarMovement => m_Wrapper.m_GameplayP2_CarMovement;
        public InputAction @Jump => m_Wrapper.m_GameplayP2_Jump;
        public InputAction @Boost => m_Wrapper.m_GameplayP2_Boost;
        public InputAction @FlipCar => m_Wrapper.m_GameplayP2_FlipCar;
        public InputAction @FlipDirection => m_Wrapper.m_GameplayP2_FlipDirection;
        public InputAction @Join => m_Wrapper.m_GameplayP2_Join;
        public InputActionMap Get() { return m_Wrapper.m_GameplayP2; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GameplayP2Actions set) { return set.Get(); }
        public void SetCallbacks(IGameplayP2Actions instance)
        {
            if (m_Wrapper.m_GameplayP2ActionsCallbackInterface != null)
            {
                @CarMovement.started -= m_Wrapper.m_GameplayP2ActionsCallbackInterface.OnCarMovement;
                @CarMovement.performed -= m_Wrapper.m_GameplayP2ActionsCallbackInterface.OnCarMovement;
                @CarMovement.canceled -= m_Wrapper.m_GameplayP2ActionsCallbackInterface.OnCarMovement;
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
                @Join.started -= m_Wrapper.m_GameplayP2ActionsCallbackInterface.OnJoin;
                @Join.performed -= m_Wrapper.m_GameplayP2ActionsCallbackInterface.OnJoin;
                @Join.canceled -= m_Wrapper.m_GameplayP2ActionsCallbackInterface.OnJoin;
            }
            m_Wrapper.m_GameplayP2ActionsCallbackInterface = instance;
            if (instance != null)
            {
                @CarMovement.started += instance.OnCarMovement;
                @CarMovement.performed += instance.OnCarMovement;
                @CarMovement.canceled += instance.OnCarMovement;
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
                @Join.started += instance.OnJoin;
                @Join.performed += instance.OnJoin;
                @Join.canceled += instance.OnJoin;
            }
        }
    }
    public GameplayP2Actions @GameplayP2 => new GameplayP2Actions(this);
    public interface IGameplayP1Actions
    {
        void OnCarMovement(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnBoost(InputAction.CallbackContext context);
        void OnFlipCar(InputAction.CallbackContext context);
        void OnFlipDirection(InputAction.CallbackContext context);
        void OnJoin(InputAction.CallbackContext context);
    }
    public interface IGameplayP2Actions
    {
        void OnCarMovement(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnBoost(InputAction.CallbackContext context);
        void OnFlipCar(InputAction.CallbackContext context);
        void OnFlipDirection(InputAction.CallbackContext context);
        void OnJoin(InputAction.CallbackContext context);
    }
}
