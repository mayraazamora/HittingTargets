using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectThrower : MonoBehaviour
{

    public string triggerName;  // Controller input name 
    public Rigidbody[] objects; // Food array being randomly selected 
    public float throwImpulse;  // Throwing food force

    private Rigidbody heldObject;  // Food that is chosen at random, cloned, and then spawned

    void Update()
    {
        // Check if the hands trigger button has been pressed
        if (Input.GetButtonDown(triggerName))
        {
            // Choose a food prefab at random to spawn
            Rigidbody randomObject = objects[Random.Range(0, objects.Length)];

            // Spawn the randomly selected food in hand
            heldObject = Instantiate(randomObject, transform.position, transform.rotation, transform);

            // Turn off gravity so that food does not fall from your hand as it spawns
            heldObject.useGravity = false;

            // Avoid having external objects interfere with our food while we are holding it
            heldObject.isKinematic = true;
        }

        // Check if the hands trigger button has been released
        if (Input.GetButtonUp(triggerName))
        {
            // Unparent food from the hand; otherwise, it will follow the hand even on the ground.
            heldObject.transform.SetParent(null);

            // Restore gravity; otherwise, food will float in space.
            heldObject.useGravity = true;

            // We want our food to interact "normally" with external forces of objects.
            heldObject.isKinematic = false;

            // Apply a force to the food object to throw it
            heldObject.AddForce(transform.forward * throwImpulse);

        }
    }
}
