using UnityEngine;
using UnityEngine.Tilemaps;
using System.Collections.Generic;
using Cinemachine;

public class SpawnObject : MonoBehaviour
{
    public GameObject playerPrefab;
    public CinemachineVirtualCamera virtualCam;
    public Tilemap tilemap;

    void Start()
    {
        tilemap = GameObject.Find("floorParent").GetComponent<Tilemap>();

        // Get the bounds of the tilemap
        BoundsInt bounds = tilemap.cellBounds;

        // List to store all filled tile positions
        List<Vector3Int> filledTilePositions = new List<Vector3Int>();

        // Loop through the tilemap and find all filled tiles
        for (int x = bounds.x; x < bounds.x + bounds.size.x; x++)
        {
            for (int y = bounds.y; y < bounds.y + bounds.size.y; y++)
            {
                Vector3Int tilePosition = new Vector3Int(x, y, 0);

                // Check if the tile at this position is filled
                if (tilemap.HasTile(tilePosition))
                {
                    // Add the position to the list of filled tiles
                    filledTilePositions.Add(tilePosition);
                }
            }
        }

        // If there are filled tiles, spawn the player at a random filled tile position
        if (filledTilePositions.Count > 0)
        {
            // Get a random index from the list of filled tile positions
            int randomIndex = Random.Range(0, filledTilePositions.Count);

            // Get the world position of the randomly selected filled tile
            Vector3 spawnWorldPosition = tilemap.GetCellCenterWorld(filledTilePositions[randomIndex]);

            // Spawn the player at the randomly selected filled tile position
            if (!GameObject.FindWithTag("Player"))
            {
                GameObject player = Instantiate(playerPrefab, spawnWorldPosition, Quaternion.identity);
                virtualCam.Follow = player.transform;
            }
            else
                GameObject.FindWithTag("Player").transform.SetPositionAndRotation(spawnWorldPosition, Quaternion.identity);

            Debug.Log("Player spawned at: " + spawnWorldPosition);
        }
        else
        {
            Debug.LogError("No filled tiles found in the tilemap.");
        }
    }
}
