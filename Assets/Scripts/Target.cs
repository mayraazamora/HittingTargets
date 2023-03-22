using UnityEngine;

public class Target : MonoBehaviour
{
    public float range;
    public float speed; 
    private Vector3 initialPosition; // The initial position of the target

    private void Start()
    {
        initialPosition = transform.position;
    }

    void Update()
    {
        // Glides target side to side while taking into acount it's initial position 
        transform.position = initialPosition + transform.right * Mathf.Sin(Time.time * speed) * range;
    }

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject); // Destroys target bullsye 
        Destroy(collision.collider.gameObject);  // Destroys food prefabs when colliding with target
        Debug.Log($"target has been hit {collision.collider.gameObject.name}"); // Logs name of food that touches target 
    }
}
