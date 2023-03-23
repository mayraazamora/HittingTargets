using UnityEngine;
public class Target : MonoBehaviour
{
    public float range;
    public float speed;
    public FoodFight game;  // Game manager script we are connecting 
    private Vector3 initialPosition; // The initial position of the target
    private void Start()
    {
        initialPosition = transform.position; // Takes into account the position of the target so target does not start at (0,0,0) 
    }
    void Update()
    {
        transform.position = initialPosition + transform.right * Mathf.Sin(Time.time * speed) * range; // Glides target side to side while taking into acount it's initial position 
    }
    private void OnCollisionEnter(Collision collision)
    {
        game.OnTargetHit(); // Let the game know the target was hit
        Destroy(gameObject); // Destroys target bullsye 
    }
}