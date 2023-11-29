using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPathfind : MonoBehaviour
{
    public GameObject playerPrefab; // Prefab of your player object
    public LayerMask obstacleLayer; // Layer mask for obstacles
    public float roomWidth = 10f; // Adjust based on your room size
    public float roomHeight = 6f; // Adjust based on your room size

    void Start()
    {
        SpawnPlayer();
    }

    void SpawnPlayer()
    {
        // Generate a random position within the room
        Vector2 randomPosition = GetRandomPosition();

        // Check if the position is valid (no obstacles)
        if (IsPositionValid(randomPosition))
        {
            // Spawn the player at the valid position
            //GameObject player = Instantiate(playerPrefab, randomPosition, Quaternion.identity);
            Debug.Log("Player Position is at : " +  randomPosition);
            // You might want to do additional setup for the player here
        }
        else
        {
            // If the position is not valid, try again (you can implement a retry mechanism)
            Debug.LogWarning("Spawn position is not valid. Retrying...");
            SpawnPlayer();
        }
    }

    Vector2 GetRandomPosition()
    {
        // Generate a random position within the room bounds
        float randomX = Random.Range(-roomWidth / 2f, roomWidth / 2f);
        float randomY = Random.Range(-roomHeight / 2f, roomHeight / 2f);

        return new Vector2(randomX, randomY);
    }

    bool IsPositionValid(Vector2 position)
    {
        // Use a small offset to avoid issues with the ground
        float offset = 0.5f;

        // Perform a raycast from above the position to check for obstacles
        Ray ray = new Ray(new Vector2(position.x, position.y + 10f), Vector2.down);

        // Adjust the ray length based on your scene's scale
        float rayLength = 20f;

        if (Physics2D.Raycast(ray.origin, ray.direction, rayLength, obstacleLayer))
        {
            // If there's an obstacle, the position is not valid
            return false;
        }

        // If there's no obstacle, the position is valid
        return true;
    }
}
