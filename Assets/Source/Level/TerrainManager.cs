using UnityEngine;
using Unity.Entities;
using Megalopolis.Level;

namespace Megalopolis.Level
{
    public class TerrainManager : MonoBehaviour
    {
        public int width = 256;
        public int height = 256;
        public int depth = 20;
        public float scale = 2;

        public Terrain terrain;

        public void Start()
        {
            terrain.terrainData = GenerateTerrain(this.terrain.terrainData);
        }

        private TerrainData GenerateTerrain(TerrainData terrainData)
        {
            terrainData.heightmapResolution = width + 1;
            terrainData.size = new Vector3(this.width, depth, this.height);

            float[,] heightMap = this.generateHeights();
            heightMap = this.normalizeHeightMap(heightMap);
            terrainData.SetHeights(0, 0, heightMap);

            return terrainData;
        }

        private float[,] generateHeights()
        {
            float[,] heights = new float[this.width, this.height];
            for (int x = 0; x < this.width; x++)
            {
                for (int y = 0; y < this.height; y++)
                {
                    heights[x, y] = calculatePointHeight(x, y);
                }
            }

            return heights;
        }

        private float[,] normalizeHeightMap(float[,] rawMap)
        {
            foreach (float xCoord in rawMap)
            {

            }
            return rawMap;
        }

        private float calculatePointHeight(int x, int y)
        {
            float xCoord = (float)x / this.width * this.scale;
            float yCoord = (float)y / this.height * this.scale;

            float noise = Mathf.PerlinNoise(xCoord, yCoord);
            noise = Mathf.PerlinNoise(
                xCoord * noise,
                yCoord * noise
            );

            return noise;
        }
    }
}