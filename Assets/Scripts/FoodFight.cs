using UnityEngine;
public class FoodFight : MonoBehaviour // This script is running on that game object we made in the scene
{
    public int score;
    public Target targetPrefab; // Target prefab we made in unity 
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
        Target newTarget = Instantiate(targetPrefab, Vector3.zero, Quaternion.Euler(-90,0,0)); // Spawns the new target
        newTarget.game = this;
    }
}
// Let the target know about the game script
// This has now way of telling me when it's been hit 
// So all you have to do is 
// The value we want to assign this game variable in our target is actually the script we are in right now
// The value we're tryign to give this is that script running on that Game (empty object)
// We are trying to pass in that script we are in right now
