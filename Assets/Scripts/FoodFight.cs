using UnityEngine;
public class FoodFight : MonoBehaviour // This script is running on that game object we made in the scene
{
    public int score;
    public Target targetPrefab; // Target prefab we made in unity 
    public BoxCollider spawnArea; 
    private void Start()
    {
        SpawnTarget(); // Spawn the 1st target
    }
    public void OnTargetHit()
    {
        score += 1;  // Increase the score by 1 
        SpawnTarget(); // Spawn a new target
    }
    private void SpawnTarget()
    {
        Vector3 randomPosition = new Vector3(
            Random.Range(spawnArea.bounds.min.x, spawnArea.bounds.max.x),
            Random.Range(spawnArea.bounds.min.y, spawnArea.bounds.max.y),
            Random.Range(spawnArea.bounds.min.z, spawnArea.bounds.max.z));
           
        Target newTarget = Instantiate(targetPrefab, randomPosition, Quaternion.Euler(-90,0,0)); // Spawns the new target
        newTarget.game = this; // Let the target know about the game script // The value we want to assign this game variable in our target is actually the script we are in right now
    }
}