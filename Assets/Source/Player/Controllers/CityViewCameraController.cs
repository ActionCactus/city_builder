using Unity.Entities;
using Unity.Transforms;
using Unity.Mathematics;
using UnityEngine;

/// <summary>
/// Player camera controller for the city gameplay view.  This will be the
/// most-used viewpoint in the game.
///
/// This is a singleton system for each client.
///
/// <see cref="https://docs.unity3d.com/Packages/com.unity.entities@0.10/manual/ecs_creating_systems.html"/>
/// <see cref="https://docs.unity3d.com/Packages/com.unity.entities@0.10/api/Unity.Entities.SystemBase.html"/>
/// </summary>
class CityViewCameraController : SystemBase
{
    protected override void OnCreate()
    {
        Debug.Log("Creating CityViewCameraController");
    }

    /// <summary>
    /// Demo use of jobs to transform the translation (position) of multiple items
    /// in separate threads.
    /// </summary>
    protected override void OnUpdate()
    {
        Entities.WithAll<Camera>()
            .ForEach((ref Translation translation) =>
            {
                translation.Value += 1.01f;
            })
            .Schedule();


        Entities.WithNone<Camera>()
            .ForEach((ref Translation translation) =>
            {
                translation.Value += 1.0f;
            })
            .ScheduleParallel();
    }
}