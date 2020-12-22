using UnityEngine;
using Unity.Entities;

[GenerateAuthoringComponent]
public struct TestSpeed : IComponentData
{
    public int test;
}