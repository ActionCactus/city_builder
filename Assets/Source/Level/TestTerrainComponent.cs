using Unity.Entities;

namespace Megalopolis.Level
{
    [GenerateAuthoringComponent]
    public struct TestTerrainComponent : IComponentData
    {
        public int myInt;
    }
}