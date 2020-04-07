// GENERATED AUTOMATICALLY FROM 'Assets/Input/UserControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @UserControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @UserControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""UserControls"",
    ""maps"": [
        {
            ""name"": ""Player1"",
            ""id"": ""e75f79fb-7938-4d1e-bee7-31257173e708"",
            ""actions"": [
                {
                    ""name"": ""AccelerateP1Controller"",
                    ""type"": ""Button"",
                    ""id"": ""021c7e29-9e05-4f9f-b374-e9e9254e75dd"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""AccelerateP1Keyboard"",
                    ""type"": ""Button"",
                    ""id"": ""3b9e4b80-af2e-4a93-8700-3a1c1839d20c"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""DecelerateP1Controller"",
                    ""type"": ""Button"",
                    ""id"": ""5d7f2df7-0cff-49c6-9a57-013e9beb52f4"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""DecelerateP1Keyboard"",
                    ""type"": ""Button"",
                    ""id"": ""8c7eabf3-452b-417f-b314-ed3cdfb76379"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""JumpP1"",
                    ""type"": ""Button"",
                    ""id"": ""4de31701-2c79-451f-a1aa-20a32228155b"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""BoostP1"",
                    ""type"": ""Value"",
                    ""id"": ""324de1ff-1c87-44e6-bc3a-8a6ac3eeaf00"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""FlipP1"",
                    ""type"": ""Button"",
                    ""id"": ""504f0a87-603a-48e2-b0e3-5e568f765348"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""VerticalP1"",
                    ""type"": ""Button"",
                    ""id"": ""fc7794de-a676-47a6-9f3d-824d609d7d23"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""HorizontalP1"",
                    ""type"": ""Button"",
                    ""id"": ""84760050-4a14-49de-922d-67c7102b2335"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""17913351-2c7f-41ca-82a2-6b1eb309d554"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""AccelerateP1Controller"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""42716372-324a-4535-b052-b22f4f6e869c"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DecelerateP1Controller"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""06169261-56f2-40bc-bf4b-d63d33456e22"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""JumpP1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""652ab54a-a5d7-45ba-adc3-0233f860a59a"",
                    ""path"": ""<Keyboard>/slash"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""JumpP1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c5ed30fa-ec1b-46b8-b7eb-3cb880c80b0b"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""BoostP1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""89025e99-1416-40e3-8e71-3b4ff7a8db21"",
                    ""path"": ""<Keyboard>/period"",
                    ""interactions"": ""Hold"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""BoostP1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""dd72b1d7-0338-4f59-be35-698b04d48654"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""FlipP1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6b787555-9843-47bb-a851-75398f8903b9"",
                    ""path"": ""<Keyboard>/comma"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""FlipP1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""02f65620-9bf5-4916-884d-67054a098995"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""VerticalP1"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""7570b78f-7139-4d8e-b59a-317d768a925e"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""VerticalP1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""8fef80fd-286e-4096-868a-1f528431189e"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""VerticalP1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""a76b3d51-c948-421b-9e33-ceaff9259b2c"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""AccelerateP1Keyboard"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0570a0f7-ecb5-4ada-a7c4-b73522f6f046"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DecelerateP1Keyboard"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""91294ef5-6864-4ccb-af5f-65a077fa1bc4"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HorizontalP1"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""e69a2a2a-2655-48e4-a4b1-7939211114bb"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HorizontalP1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""51c6949a-3801-443f-8370-866c4bc0a55e"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HorizontalP1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""c2fa7018-e1d9-44d1-a05f-fa50e878ac10"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HorizontalP1"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""d24101ba-b2c0-4db9-8e0c-2dc7bd8b2453"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HorizontalP1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""9a2a574d-cc1a-4e3c-82ab-b04d09932554"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HorizontalP1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        },
        {
            ""name"": ""Player2"",
            ""id"": ""5e9f1582-3278-40a7-998f-8f842d82a372"",
            ""actions"": [
                {
                    ""name"": ""AccelerateP1Controller"",
                    ""type"": ""Button"",
                    ""id"": ""d5a0b739-bc61-4f84-9bfc-4f5e8d98e4c7"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""AccelerateP1Keyboard"",
                    ""type"": ""Button"",
                    ""id"": ""cc9a3b51-4562-475b-aaed-5bdfdeb17856"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""DecelerateP1Controller"",
                    ""type"": ""Button"",
                    ""id"": ""e6073dc4-2de4-45ea-8678-eebf3e53e862"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""DecelerateP1Keyboard"",
                    ""type"": ""Button"",
                    ""id"": ""9f33941d-cf1c-4803-9cce-b10e848d1faa"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""JumpP1"",
                    ""type"": ""Button"",
                    ""id"": ""24b52ff3-e7a4-46a9-9444-117c10635d7f"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""BoostP1"",
                    ""type"": ""Button"",
                    ""id"": ""ae579927-d9d3-4a33-a221-cecc12d7064e"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""FlipP1"",
                    ""type"": ""Button"",
                    ""id"": ""e486b17f-b340-4f4a-92d4-1dd1fa014c69"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""VerticalP1"",
                    ""type"": ""Button"",
                    ""id"": ""0188128a-9a69-4d65-b157-3aa5b91d5623"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""HorizontalP1"",
                    ""type"": ""Button"",
                    ""id"": ""0af2914f-79ea-41e2-acfa-88472d96b65e"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""dddadcc7-5ebe-4e54-82c5-5d4be8260de3"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""AccelerateP1Controller"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9a488333-23cb-4a46-aee4-e3eb24deeb2e"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DecelerateP1Controller"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2aa3aca0-a292-4d87-bea8-c0aac3f857f2"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""JumpP1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4637f650-a33c-43d2-a07d-0970591f8289"",
                    ""path"": ""<Keyboard>/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""JumpP1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6a4bf4b7-4b9d-4ce3-b586-d762b42f08f7"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""BoostP1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""cdfeb1fb-738b-4c32-93d2-8300438caa63"",
                    ""path"": ""<Keyboard>/z"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""BoostP1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c862d9fa-d482-427f-a961-2ef451e61bf1"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""FlipP1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""49c871bb-3c27-45df-aa13-3c4fdd4d5ea5"",
                    ""path"": ""<Keyboard>/OEM1"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""FlipP1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""c8c36961-9a53-4959-983e-a27b082bcef7"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""VerticalP1"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""ab8774b3-c2c0-4ea5-912e-11ad6a279a74"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""VerticalP1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""0fd24b72-7516-4fb2-b89c-3a9ab8a1b2d9"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""VerticalP1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""6869dff6-e08c-4a73-b9b6-ce04912d1b95"",
                    ""path"": ""<Keyboard>/t"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""AccelerateP1Keyboard"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0b6eaf46-6b8b-4e50-8af3-1dccc1ca44bd"",
                    ""path"": ""<Keyboard>/g"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DecelerateP1Keyboard"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""8af98653-7f54-4562-90af-c7b262d688de"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HorizontalP1"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""4050d929-d6c6-4480-ba0c-5787251b109b"",
                    ""path"": ""<Keyboard>/f"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HorizontalP1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""857c2c6c-996f-48e8-ba8e-bc203cf90c93"",
                    ""path"": ""<Keyboard>/h"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HorizontalP1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""094c10fe-9353-4a4b-a7b3-d6b9febf4da7"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HorizontalP1"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""2de9ff6a-5956-443e-b819-de5332670272"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HorizontalP1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""838c6d7e-8f04-4e3e-a149-e9c3fa62e55b"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HorizontalP1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        },
        {
            ""name"": ""MenuInteraction"",
            ""id"": ""68f9a5d2-3e87-414b-a99a-4249fde5dfe8"",
            ""actions"": [
                {
                    ""name"": ""Submit"",
                    ""type"": ""Button"",
                    ""id"": ""8784b1d5-5e8c-40bf-98dd-d78773f2d973"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Pause"",
                    ""type"": ""Button"",
                    ""id"": ""5530dfbf-aca2-45fa-bdd4-0ca745fc97cb"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Restart"",
                    ""type"": ""Button"",
                    ""id"": ""006a81b3-7923-454f-9a62-eecd86feabba"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MenuNavigation"",
                    ""type"": ""Button"",
                    ""id"": ""6dd1311a-a754-43dd-a64f-24e3e9b01e81"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""10281259-e9fa-4c68-971f-9cc67f4953f4"",
                    ""path"": ""<Keyboard>/enter"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Submit"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5c35d02a-e94b-4ee7-9bd2-7d031a798d44"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Submit"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f853f37d-fa4f-4f74-882f-75cc59a43dfb"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b76e18e5-af9e-42e4-8e24-e18db1674445"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1a46db64-7806-453b-8942-289be7929503"",
                    ""path"": ""<Keyboard>/r"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Restart"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""14710b7f-e474-4f0f-86ac-5ee92d4bef6b"",
                    ""path"": ""<Gamepad>/select"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Restart"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""d1dd17c8-f9be-4868-a8e4-a5fa27e68304"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MenuNavigation"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""d761d1a0-dcc2-495a-8514-fe765e3f13a4"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MenuNavigation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""61f14a3a-b3dc-49c5-b8d4-9ca2ea1d0702"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MenuNavigation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""9301a2eb-d0d4-4b3f-990e-912d46d22669"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MenuNavigation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""dd84d2f7-b767-4550-8e71-ab993de30973"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MenuNavigation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""35e43023-bd20-4db4-bf83-2c02e8b8a272"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MenuNavigation"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""7cd87712-efeb-46bf-9983-8f450cabb9dd"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MenuNavigation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""11c8651f-652f-4b81-b1a0-e93e7fafb43f"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MenuNavigation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""4521f6f7-72c8-4b0c-8d0c-b0b671b00bc9"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MenuNavigation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""fad1c05e-06c8-49fd-af73-10382a6111f3"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MenuNavigation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""fcecba70-1197-4375-ab8e-32377b42d0c1"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MenuNavigation"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""d30ed6cf-ad27-45bd-894a-4f49f1a7f6d2"",
                    ""path"": ""<Gamepad>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MenuNavigation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""1482aef5-3958-4840-81a9-f778fe69ea46"",
                    ""path"": ""<Gamepad>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MenuNavigation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""fbf4c5b2-6acd-4ce4-b671-983f250f71bb"",
                    ""path"": ""<Gamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MenuNavigation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""94c4e9bb-2144-401b-ba4d-38f619f19249"",
                    ""path"": ""<Gamepad>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MenuNavigation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Player1
        m_Player1 = asset.FindActionMap("Player1", throwIfNotFound: true);
        m_Player1_AccelerateP1Controller = m_Player1.FindAction("AccelerateP1Controller", throwIfNotFound: true);
        m_Player1_AccelerateP1Keyboard = m_Player1.FindAction("AccelerateP1Keyboard", throwIfNotFound: true);
        m_Player1_DecelerateP1Controller = m_Player1.FindAction("DecelerateP1Controller", throwIfNotFound: true);
        m_Player1_DecelerateP1Keyboard = m_Player1.FindAction("DecelerateP1Keyboard", throwIfNotFound: true);
        m_Player1_JumpP1 = m_Player1.FindAction("JumpP1", throwIfNotFound: true);
        m_Player1_BoostP1 = m_Player1.FindAction("BoostP1", throwIfNotFound: true);
        m_Player1_FlipP1 = m_Player1.FindAction("FlipP1", throwIfNotFound: true);
        m_Player1_VerticalP1 = m_Player1.FindAction("VerticalP1", throwIfNotFound: true);
        m_Player1_HorizontalP1 = m_Player1.FindAction("HorizontalP1", throwIfNotFound: true);
        // Player2
        m_Player2 = asset.FindActionMap("Player2", throwIfNotFound: true);
        m_Player2_AccelerateP1Controller = m_Player2.FindAction("AccelerateP1Controller", throwIfNotFound: true);
        m_Player2_AccelerateP1Keyboard = m_Player2.FindAction("AccelerateP1Keyboard", throwIfNotFound: true);
        m_Player2_DecelerateP1Controller = m_Player2.FindAction("DecelerateP1Controller", throwIfNotFound: true);
        m_Player2_DecelerateP1Keyboard = m_Player2.FindAction("DecelerateP1Keyboard", throwIfNotFound: true);
        m_Player2_JumpP1 = m_Player2.FindAction("JumpP1", throwIfNotFound: true);
        m_Player2_BoostP1 = m_Player2.FindAction("BoostP1", throwIfNotFound: true);
        m_Player2_FlipP1 = m_Player2.FindAction("FlipP1", throwIfNotFound: true);
        m_Player2_VerticalP1 = m_Player2.FindAction("VerticalP1", throwIfNotFound: true);
        m_Player2_HorizontalP1 = m_Player2.FindAction("HorizontalP1", throwIfNotFound: true);
        // MenuInteraction
        m_MenuInteraction = asset.FindActionMap("MenuInteraction", throwIfNotFound: true);
        m_MenuInteraction_Submit = m_MenuInteraction.FindAction("Submit", throwIfNotFound: true);
        m_MenuInteraction_Pause = m_MenuInteraction.FindAction("Pause", throwIfNotFound: true);
        m_MenuInteraction_Restart = m_MenuInteraction.FindAction("Restart", throwIfNotFound: true);
        m_MenuInteraction_MenuNavigation = m_MenuInteraction.FindAction("MenuNavigation", throwIfNotFound: true);
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

    // Player1
    private readonly InputActionMap m_Player1;
    private IPlayer1Actions m_Player1ActionsCallbackInterface;
    private readonly InputAction m_Player1_AccelerateP1Controller;
    private readonly InputAction m_Player1_AccelerateP1Keyboard;
    private readonly InputAction m_Player1_DecelerateP1Controller;
    private readonly InputAction m_Player1_DecelerateP1Keyboard;
    private readonly InputAction m_Player1_JumpP1;
    private readonly InputAction m_Player1_BoostP1;
    private readonly InputAction m_Player1_FlipP1;
    private readonly InputAction m_Player1_VerticalP1;
    private readonly InputAction m_Player1_HorizontalP1;
    public struct Player1Actions
    {
        private @UserControls m_Wrapper;
        public Player1Actions(@UserControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @AccelerateP1Controller => m_Wrapper.m_Player1_AccelerateP1Controller;
        public InputAction @AccelerateP1Keyboard => m_Wrapper.m_Player1_AccelerateP1Keyboard;
        public InputAction @DecelerateP1Controller => m_Wrapper.m_Player1_DecelerateP1Controller;
        public InputAction @DecelerateP1Keyboard => m_Wrapper.m_Player1_DecelerateP1Keyboard;
        public InputAction @JumpP1 => m_Wrapper.m_Player1_JumpP1;
        public InputAction @BoostP1 => m_Wrapper.m_Player1_BoostP1;
        public InputAction @FlipP1 => m_Wrapper.m_Player1_FlipP1;
        public InputAction @VerticalP1 => m_Wrapper.m_Player1_VerticalP1;
        public InputAction @HorizontalP1 => m_Wrapper.m_Player1_HorizontalP1;
        public InputActionMap Get() { return m_Wrapper.m_Player1; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(Player1Actions set) { return set.Get(); }
        public void SetCallbacks(IPlayer1Actions instance)
        {
            if (m_Wrapper.m_Player1ActionsCallbackInterface != null)
            {
                @AccelerateP1Controller.started -= m_Wrapper.m_Player1ActionsCallbackInterface.OnAccelerateP1Controller;
                @AccelerateP1Controller.performed -= m_Wrapper.m_Player1ActionsCallbackInterface.OnAccelerateP1Controller;
                @AccelerateP1Controller.canceled -= m_Wrapper.m_Player1ActionsCallbackInterface.OnAccelerateP1Controller;
                @AccelerateP1Keyboard.started -= m_Wrapper.m_Player1ActionsCallbackInterface.OnAccelerateP1Keyboard;
                @AccelerateP1Keyboard.performed -= m_Wrapper.m_Player1ActionsCallbackInterface.OnAccelerateP1Keyboard;
                @AccelerateP1Keyboard.canceled -= m_Wrapper.m_Player1ActionsCallbackInterface.OnAccelerateP1Keyboard;
                @DecelerateP1Controller.started -= m_Wrapper.m_Player1ActionsCallbackInterface.OnDecelerateP1Controller;
                @DecelerateP1Controller.performed -= m_Wrapper.m_Player1ActionsCallbackInterface.OnDecelerateP1Controller;
                @DecelerateP1Controller.canceled -= m_Wrapper.m_Player1ActionsCallbackInterface.OnDecelerateP1Controller;
                @DecelerateP1Keyboard.started -= m_Wrapper.m_Player1ActionsCallbackInterface.OnDecelerateP1Keyboard;
                @DecelerateP1Keyboard.performed -= m_Wrapper.m_Player1ActionsCallbackInterface.OnDecelerateP1Keyboard;
                @DecelerateP1Keyboard.canceled -= m_Wrapper.m_Player1ActionsCallbackInterface.OnDecelerateP1Keyboard;
                @JumpP1.started -= m_Wrapper.m_Player1ActionsCallbackInterface.OnJumpP1;
                @JumpP1.performed -= m_Wrapper.m_Player1ActionsCallbackInterface.OnJumpP1;
                @JumpP1.canceled -= m_Wrapper.m_Player1ActionsCallbackInterface.OnJumpP1;
                @BoostP1.started -= m_Wrapper.m_Player1ActionsCallbackInterface.OnBoostP1;
                @BoostP1.performed -= m_Wrapper.m_Player1ActionsCallbackInterface.OnBoostP1;
                @BoostP1.canceled -= m_Wrapper.m_Player1ActionsCallbackInterface.OnBoostP1;
                @FlipP1.started -= m_Wrapper.m_Player1ActionsCallbackInterface.OnFlipP1;
                @FlipP1.performed -= m_Wrapper.m_Player1ActionsCallbackInterface.OnFlipP1;
                @FlipP1.canceled -= m_Wrapper.m_Player1ActionsCallbackInterface.OnFlipP1;
                @VerticalP1.started -= m_Wrapper.m_Player1ActionsCallbackInterface.OnVerticalP1;
                @VerticalP1.performed -= m_Wrapper.m_Player1ActionsCallbackInterface.OnVerticalP1;
                @VerticalP1.canceled -= m_Wrapper.m_Player1ActionsCallbackInterface.OnVerticalP1;
                @HorizontalP1.started -= m_Wrapper.m_Player1ActionsCallbackInterface.OnHorizontalP1;
                @HorizontalP1.performed -= m_Wrapper.m_Player1ActionsCallbackInterface.OnHorizontalP1;
                @HorizontalP1.canceled -= m_Wrapper.m_Player1ActionsCallbackInterface.OnHorizontalP1;
            }
            m_Wrapper.m_Player1ActionsCallbackInterface = instance;
            if (instance != null)
            {
                @AccelerateP1Controller.started += instance.OnAccelerateP1Controller;
                @AccelerateP1Controller.performed += instance.OnAccelerateP1Controller;
                @AccelerateP1Controller.canceled += instance.OnAccelerateP1Controller;
                @AccelerateP1Keyboard.started += instance.OnAccelerateP1Keyboard;
                @AccelerateP1Keyboard.performed += instance.OnAccelerateP1Keyboard;
                @AccelerateP1Keyboard.canceled += instance.OnAccelerateP1Keyboard;
                @DecelerateP1Controller.started += instance.OnDecelerateP1Controller;
                @DecelerateP1Controller.performed += instance.OnDecelerateP1Controller;
                @DecelerateP1Controller.canceled += instance.OnDecelerateP1Controller;
                @DecelerateP1Keyboard.started += instance.OnDecelerateP1Keyboard;
                @DecelerateP1Keyboard.performed += instance.OnDecelerateP1Keyboard;
                @DecelerateP1Keyboard.canceled += instance.OnDecelerateP1Keyboard;
                @JumpP1.started += instance.OnJumpP1;
                @JumpP1.performed += instance.OnJumpP1;
                @JumpP1.canceled += instance.OnJumpP1;
                @BoostP1.started += instance.OnBoostP1;
                @BoostP1.performed += instance.OnBoostP1;
                @BoostP1.canceled += instance.OnBoostP1;
                @FlipP1.started += instance.OnFlipP1;
                @FlipP1.performed += instance.OnFlipP1;
                @FlipP1.canceled += instance.OnFlipP1;
                @VerticalP1.started += instance.OnVerticalP1;
                @VerticalP1.performed += instance.OnVerticalP1;
                @VerticalP1.canceled += instance.OnVerticalP1;
                @HorizontalP1.started += instance.OnHorizontalP1;
                @HorizontalP1.performed += instance.OnHorizontalP1;
                @HorizontalP1.canceled += instance.OnHorizontalP1;
            }
        }
    }
    public Player1Actions @Player1 => new Player1Actions(this);

    // Player2
    private readonly InputActionMap m_Player2;
    private IPlayer2Actions m_Player2ActionsCallbackInterface;
    private readonly InputAction m_Player2_AccelerateP1Controller;
    private readonly InputAction m_Player2_AccelerateP1Keyboard;
    private readonly InputAction m_Player2_DecelerateP1Controller;
    private readonly InputAction m_Player2_DecelerateP1Keyboard;
    private readonly InputAction m_Player2_JumpP1;
    private readonly InputAction m_Player2_BoostP1;
    private readonly InputAction m_Player2_FlipP1;
    private readonly InputAction m_Player2_VerticalP1;
    private readonly InputAction m_Player2_HorizontalP1;
    public struct Player2Actions
    {
        private @UserControls m_Wrapper;
        public Player2Actions(@UserControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @AccelerateP1Controller => m_Wrapper.m_Player2_AccelerateP1Controller;
        public InputAction @AccelerateP1Keyboard => m_Wrapper.m_Player2_AccelerateP1Keyboard;
        public InputAction @DecelerateP1Controller => m_Wrapper.m_Player2_DecelerateP1Controller;
        public InputAction @DecelerateP1Keyboard => m_Wrapper.m_Player2_DecelerateP1Keyboard;
        public InputAction @JumpP1 => m_Wrapper.m_Player2_JumpP1;
        public InputAction @BoostP1 => m_Wrapper.m_Player2_BoostP1;
        public InputAction @FlipP1 => m_Wrapper.m_Player2_FlipP1;
        public InputAction @VerticalP1 => m_Wrapper.m_Player2_VerticalP1;
        public InputAction @HorizontalP1 => m_Wrapper.m_Player2_HorizontalP1;
        public InputActionMap Get() { return m_Wrapper.m_Player2; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(Player2Actions set) { return set.Get(); }
        public void SetCallbacks(IPlayer2Actions instance)
        {
            if (m_Wrapper.m_Player2ActionsCallbackInterface != null)
            {
                @AccelerateP1Controller.started -= m_Wrapper.m_Player2ActionsCallbackInterface.OnAccelerateP1Controller;
                @AccelerateP1Controller.performed -= m_Wrapper.m_Player2ActionsCallbackInterface.OnAccelerateP1Controller;
                @AccelerateP1Controller.canceled -= m_Wrapper.m_Player2ActionsCallbackInterface.OnAccelerateP1Controller;
                @AccelerateP1Keyboard.started -= m_Wrapper.m_Player2ActionsCallbackInterface.OnAccelerateP1Keyboard;
                @AccelerateP1Keyboard.performed -= m_Wrapper.m_Player2ActionsCallbackInterface.OnAccelerateP1Keyboard;
                @AccelerateP1Keyboard.canceled -= m_Wrapper.m_Player2ActionsCallbackInterface.OnAccelerateP1Keyboard;
                @DecelerateP1Controller.started -= m_Wrapper.m_Player2ActionsCallbackInterface.OnDecelerateP1Controller;
                @DecelerateP1Controller.performed -= m_Wrapper.m_Player2ActionsCallbackInterface.OnDecelerateP1Controller;
                @DecelerateP1Controller.canceled -= m_Wrapper.m_Player2ActionsCallbackInterface.OnDecelerateP1Controller;
                @DecelerateP1Keyboard.started -= m_Wrapper.m_Player2ActionsCallbackInterface.OnDecelerateP1Keyboard;
                @DecelerateP1Keyboard.performed -= m_Wrapper.m_Player2ActionsCallbackInterface.OnDecelerateP1Keyboard;
                @DecelerateP1Keyboard.canceled -= m_Wrapper.m_Player2ActionsCallbackInterface.OnDecelerateP1Keyboard;
                @JumpP1.started -= m_Wrapper.m_Player2ActionsCallbackInterface.OnJumpP1;
                @JumpP1.performed -= m_Wrapper.m_Player2ActionsCallbackInterface.OnJumpP1;
                @JumpP1.canceled -= m_Wrapper.m_Player2ActionsCallbackInterface.OnJumpP1;
                @BoostP1.started -= m_Wrapper.m_Player2ActionsCallbackInterface.OnBoostP1;
                @BoostP1.performed -= m_Wrapper.m_Player2ActionsCallbackInterface.OnBoostP1;
                @BoostP1.canceled -= m_Wrapper.m_Player2ActionsCallbackInterface.OnBoostP1;
                @FlipP1.started -= m_Wrapper.m_Player2ActionsCallbackInterface.OnFlipP1;
                @FlipP1.performed -= m_Wrapper.m_Player2ActionsCallbackInterface.OnFlipP1;
                @FlipP1.canceled -= m_Wrapper.m_Player2ActionsCallbackInterface.OnFlipP1;
                @VerticalP1.started -= m_Wrapper.m_Player2ActionsCallbackInterface.OnVerticalP1;
                @VerticalP1.performed -= m_Wrapper.m_Player2ActionsCallbackInterface.OnVerticalP1;
                @VerticalP1.canceled -= m_Wrapper.m_Player2ActionsCallbackInterface.OnVerticalP1;
                @HorizontalP1.started -= m_Wrapper.m_Player2ActionsCallbackInterface.OnHorizontalP1;
                @HorizontalP1.performed -= m_Wrapper.m_Player2ActionsCallbackInterface.OnHorizontalP1;
                @HorizontalP1.canceled -= m_Wrapper.m_Player2ActionsCallbackInterface.OnHorizontalP1;
            }
            m_Wrapper.m_Player2ActionsCallbackInterface = instance;
            if (instance != null)
            {
                @AccelerateP1Controller.started += instance.OnAccelerateP1Controller;
                @AccelerateP1Controller.performed += instance.OnAccelerateP1Controller;
                @AccelerateP1Controller.canceled += instance.OnAccelerateP1Controller;
                @AccelerateP1Keyboard.started += instance.OnAccelerateP1Keyboard;
                @AccelerateP1Keyboard.performed += instance.OnAccelerateP1Keyboard;
                @AccelerateP1Keyboard.canceled += instance.OnAccelerateP1Keyboard;
                @DecelerateP1Controller.started += instance.OnDecelerateP1Controller;
                @DecelerateP1Controller.performed += instance.OnDecelerateP1Controller;
                @DecelerateP1Controller.canceled += instance.OnDecelerateP1Controller;
                @DecelerateP1Keyboard.started += instance.OnDecelerateP1Keyboard;
                @DecelerateP1Keyboard.performed += instance.OnDecelerateP1Keyboard;
                @DecelerateP1Keyboard.canceled += instance.OnDecelerateP1Keyboard;
                @JumpP1.started += instance.OnJumpP1;
                @JumpP1.performed += instance.OnJumpP1;
                @JumpP1.canceled += instance.OnJumpP1;
                @BoostP1.started += instance.OnBoostP1;
                @BoostP1.performed += instance.OnBoostP1;
                @BoostP1.canceled += instance.OnBoostP1;
                @FlipP1.started += instance.OnFlipP1;
                @FlipP1.performed += instance.OnFlipP1;
                @FlipP1.canceled += instance.OnFlipP1;
                @VerticalP1.started += instance.OnVerticalP1;
                @VerticalP1.performed += instance.OnVerticalP1;
                @VerticalP1.canceled += instance.OnVerticalP1;
                @HorizontalP1.started += instance.OnHorizontalP1;
                @HorizontalP1.performed += instance.OnHorizontalP1;
                @HorizontalP1.canceled += instance.OnHorizontalP1;
            }
        }
    }
    public Player2Actions @Player2 => new Player2Actions(this);

    // MenuInteraction
    private readonly InputActionMap m_MenuInteraction;
    private IMenuInteractionActions m_MenuInteractionActionsCallbackInterface;
    private readonly InputAction m_MenuInteraction_Submit;
    private readonly InputAction m_MenuInteraction_Pause;
    private readonly InputAction m_MenuInteraction_Restart;
    private readonly InputAction m_MenuInteraction_MenuNavigation;
    public struct MenuInteractionActions
    {
        private @UserControls m_Wrapper;
        public MenuInteractionActions(@UserControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Submit => m_Wrapper.m_MenuInteraction_Submit;
        public InputAction @Pause => m_Wrapper.m_MenuInteraction_Pause;
        public InputAction @Restart => m_Wrapper.m_MenuInteraction_Restart;
        public InputAction @MenuNavigation => m_Wrapper.m_MenuInteraction_MenuNavigation;
        public InputActionMap Get() { return m_Wrapper.m_MenuInteraction; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MenuInteractionActions set) { return set.Get(); }
        public void SetCallbacks(IMenuInteractionActions instance)
        {
            if (m_Wrapper.m_MenuInteractionActionsCallbackInterface != null)
            {
                @Submit.started -= m_Wrapper.m_MenuInteractionActionsCallbackInterface.OnSubmit;
                @Submit.performed -= m_Wrapper.m_MenuInteractionActionsCallbackInterface.OnSubmit;
                @Submit.canceled -= m_Wrapper.m_MenuInteractionActionsCallbackInterface.OnSubmit;
                @Pause.started -= m_Wrapper.m_MenuInteractionActionsCallbackInterface.OnPause;
                @Pause.performed -= m_Wrapper.m_MenuInteractionActionsCallbackInterface.OnPause;
                @Pause.canceled -= m_Wrapper.m_MenuInteractionActionsCallbackInterface.OnPause;
                @Restart.started -= m_Wrapper.m_MenuInteractionActionsCallbackInterface.OnRestart;
                @Restart.performed -= m_Wrapper.m_MenuInteractionActionsCallbackInterface.OnRestart;
                @Restart.canceled -= m_Wrapper.m_MenuInteractionActionsCallbackInterface.OnRestart;
                @MenuNavigation.started -= m_Wrapper.m_MenuInteractionActionsCallbackInterface.OnMenuNavigation;
                @MenuNavigation.performed -= m_Wrapper.m_MenuInteractionActionsCallbackInterface.OnMenuNavigation;
                @MenuNavigation.canceled -= m_Wrapper.m_MenuInteractionActionsCallbackInterface.OnMenuNavigation;
            }
            m_Wrapper.m_MenuInteractionActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Submit.started += instance.OnSubmit;
                @Submit.performed += instance.OnSubmit;
                @Submit.canceled += instance.OnSubmit;
                @Pause.started += instance.OnPause;
                @Pause.performed += instance.OnPause;
                @Pause.canceled += instance.OnPause;
                @Restart.started += instance.OnRestart;
                @Restart.performed += instance.OnRestart;
                @Restart.canceled += instance.OnRestart;
                @MenuNavigation.started += instance.OnMenuNavigation;
                @MenuNavigation.performed += instance.OnMenuNavigation;
                @MenuNavigation.canceled += instance.OnMenuNavigation;
            }
        }
    }
    public MenuInteractionActions @MenuInteraction => new MenuInteractionActions(this);
    public interface IPlayer1Actions
    {
        void OnAccelerateP1Controller(InputAction.CallbackContext context);
        void OnAccelerateP1Keyboard(InputAction.CallbackContext context);
        void OnDecelerateP1Controller(InputAction.CallbackContext context);
        void OnDecelerateP1Keyboard(InputAction.CallbackContext context);
        void OnJumpP1(InputAction.CallbackContext context);
        void OnBoostP1(InputAction.CallbackContext context);
        void OnFlipP1(InputAction.CallbackContext context);
        void OnVerticalP1(InputAction.CallbackContext context);
        void OnHorizontalP1(InputAction.CallbackContext context);
    }
    public interface IPlayer2Actions
    {
        void OnAccelerateP1Controller(InputAction.CallbackContext context);
        void OnAccelerateP1Keyboard(InputAction.CallbackContext context);
        void OnDecelerateP1Controller(InputAction.CallbackContext context);
        void OnDecelerateP1Keyboard(InputAction.CallbackContext context);
        void OnJumpP1(InputAction.CallbackContext context);
        void OnBoostP1(InputAction.CallbackContext context);
        void OnFlipP1(InputAction.CallbackContext context);
        void OnVerticalP1(InputAction.CallbackContext context);
        void OnHorizontalP1(InputAction.CallbackContext context);
    }
    public interface IMenuInteractionActions
    {
        void OnSubmit(InputAction.CallbackContext context);
        void OnPause(InputAction.CallbackContext context);
        void OnRestart(InputAction.CallbackContext context);
        void OnMenuNavigation(InputAction.CallbackContext context);
    }
}
