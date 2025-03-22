using UnityEngine;

public class GameManager : MonoBehaviour
{
   public BlockSpawner blockSpawner;

   private void Start()
   {
      InvokeRepeating(nameof(SpawnBlocks), 2f, 3f);
   }

   private void SpawnBlocks()
   {
      blockSpawner.SpawnBlock(1);
      blockSpawner.SpawnBlock(2);
   }
}
