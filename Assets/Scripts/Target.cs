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
        // Glides target side to side while taking into acount it's initial position 
        transform.position = initialPosition + transform.right * Mathf.Sin(Time.time * speed) * range;
    }

    private void OnCollisionEnter(Collision collision)
    {
        game.OnTargetHit(); // Let the game know the target was hit
        Destroy(gameObject); // Destroys target bullsye 
        Destroy(collision.collider.gameObject);  // Destroys food prefabs when colliding with target
    }
}

// Logs name of food that touches target 
// Debug.Log($"target has been hit {collision.collider.gameObject.name}");