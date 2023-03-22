using UnityEngine;

public class Target : MonoBehaviour
{
    public float range;
    public float speed;
    private Vector3 initialPosition;

    private void Start()
    {
        initialPosition = transform.position;
    }

    void Update()
    {
        transform.position = initialPosition + transform.right * Mathf.Sin(Time.time * speed) * range;
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log($"target has been hit {collision.collider.gameObject.name}");
    }
}
