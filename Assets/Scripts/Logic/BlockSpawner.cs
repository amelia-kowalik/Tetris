using System;
using UnityEngine;

public class BlockSpawner : MonoBehaviour
{
    public GameObject blockPrefab;
    public Transform player1Spawn;
    public Transform player2Spawn;
    
    public event Action<GameObject, int> OnBlockSpawn;

    public void SpawnBlock(int playerId)
    {
        Transform spawnPoint;
        if (playerId == 1)
        {
            spawnPoint = player1Spawn;
        }
        else
        {
            spawnPoint = player2Spawn;
        }
        
        GameObject block = Instantiate(blockPrefab, spawnPoint.position, Quaternion.identity);
        
        OnBlockSpawn?.Invoke(block, playerId);
    }
}
