using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectThrower : MonoBehaviour
{
    public string triggerName;
    public Rigidbody[] objects;

    private Rigidbody heldObject;

    // Update is called once per frame
    void Update()
    {
        // Check if the hands trigger button has been pressed
        if (Input.GetButtonDown(triggerName))
        {
            // Randomly choose a game object from an array to spawn
            Rigidbody randomObject = objects[Random.Range(0, objects.Length)];

            //Spawn the randomly choosen food prefab
            heldObject = Instantiate(randomObject, transform.position, transform.rotation, transform);
            heldObject.useGravity = false;
            heldObject.isKinematic = true;
        }

        // Check if the hands trigger button has been released
        if (Input.GetButtonUp(triggerName))
        {
            // Detach the food object from the hand
            heldObject.transform.SetParent(null);
            heldObject.useGravity = true;
            heldObject.isKinematic = false;

            // Apply a force to the food object to throw it
        }
    }
}
