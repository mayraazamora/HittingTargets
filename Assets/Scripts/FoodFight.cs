using UnityEngine;
public class FoodFight : MonoBehaviour 
{
        public Target targetPrefab; 
        public BoxCollider spawnArea;
        public float gameDuration;
        public int score;
        public float countdown;
    private void Start()
    {
        // Spawn the first target
        SpawnTarget();

        // Reset the game countdown
        countdown = gameDuration;
    }
    public void OnTargetHit()
    {
        score += 1; 
        SpawnTarget(); 
    }
    private void Update()
    {
        //Decrease the game countdown
        countdown -= Time.deltaTime;
    }
    private void SpawnTarget()
    {
        Vector3 randomPosition = new Vector3(
            Random.Range(spawnArea.bounds.min.x, spawnArea.bounds.max.x),
            Random.Range(spawnArea.bounds.min.y, spawnArea.bounds.max.y),
            Random.Range(spawnArea.bounds.min.z, spawnArea.bounds.max.z));
           
        Target newTarget = Instantiate(targetPrefab, randomPosition, Quaternion.Euler(-90,0,0)); 
        newTarget.game = this; 
    }
}