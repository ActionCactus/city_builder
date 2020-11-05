# Overview

This is a city builder

# Development Instructions

## Using ECS
We're using the Hybrid ECS approach for now since it'll allow us to utilize MonoBehavior for features not yet implemented in DOTS while enabling us to get the architectural and performance improvements which come from an ECS game.

Useful links:
* [Creating ECS gameplay](https://docs.unity3d.com/Packages/com.unity.entities@0.7/manual/gp_overview.html)

### Notes
* Converting GameObjects to entities
  * Game objects with *ConvertToEntity* components are converted to Entities at runtime
  * Subscenes are converted to entities at build time and are serialized to disk
  * Use the [IConvertGameObjectToEntity](https://docs.unity3d.com/Packages/com.unity.entities@0.7/api/Unity.Entities.IConvertGameObjectToEntity.html) interface to specify custom conversion steps
* Authoring components
  * Authoring components are used to expose the data of a component to the Unity editor
  * Only one component per file can use this
  * Can be used on IBufferElementData structs as well
  * Use the GenerateAuthoringComponent attribute
```
[GenerateAuthoringComponent]
public struct MyComponent : IComponentData
{
    public float testValue;
}
```