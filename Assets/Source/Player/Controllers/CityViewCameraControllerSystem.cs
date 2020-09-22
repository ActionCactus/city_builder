using Unity.Entities;
using UnityEngine;
using UnityEngine.InputSystem;
using Megalopolis.Player.Input;

// Reference this: https://github.com/Unity-Technologies/EntityComponentSystemSamples/blob/d616c1b077c306e6f31b41a3970799e4b132139b/UnityPhysicsSamples/Assets/Common/Scripts/DemoInputGatheringSystem.cs

[AlwaysUpdateSystem]
class CityViewCameraControllerSystem : ComponentSystem
{
    IInputActionCollection inputActions;

    protected override void OnCreate()
    {
        this.inputActions = new Megalopolis.Player.Input.CityViewCameraInputActions();
        this.inputActions.Enable();
        Debug.Log("Input actions created and enabled");
        // 1) set up entity queries to gather the camera entity
        // 2)
    }

    protected override void OnUpdate()
    {

    }
}