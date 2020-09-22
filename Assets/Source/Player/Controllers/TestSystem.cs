using Unity.Entities;
using UnityEngine;
using UnityEngine.InputSystem;

class TestSystem : SystemBase
{
    private int inc = 0;

    protected override void OnCreate()
    {
        // Debug.Log("OnCreate");
    }

    protected override void OnUpdate()
    {
        if (this.inc % 10 == 0)
        {
            // Debug.Log("OnUpdate Test " + this.inc);
        }
        this.inc++;
    }
}