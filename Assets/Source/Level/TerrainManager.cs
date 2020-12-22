using UnityEngine;
using Unity.Entities;
using Megalopolis.Level;

namespace Megalopolis.Level
{
    public class TerrainManager : ComponentSystem
    {
        private bool levelGenerated = false;

        protected override void OnUpdate()
        {
            if (this.levelGenerated == false)
            {
                this.generateTerrainHeightmap();
            }
        }

        private void generateTerrainHeightmap()
        {
            // Ugh.  Terrain not supported in DOTS right now.  This is horrible...
            Entities.WithAll<TestTerrainComponent>().ForEach((Entity e) =>
            {

            });
        }
    }
}