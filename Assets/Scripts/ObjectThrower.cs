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
        if (Input.GetButtonDown(triggerName)) // Check if the hands trigger button has been pressed
        {
            Rigidbody randomObject = objects[Random.Range(0, objects.Length)]; // Choose a food prefab at random to spawn
            heldObject = Instantiate(randomObject, transform.position, transform.rotation, transform); // Spawn the randomly selected food in hand         
            heldObject.useGravity = false; // Turn off gravity so that food does not fall from your hand as it spawns          
            heldObject.isKinematic = true; // Avoid having external objects interfere with our food while we are holding it
        }

        if (Input.GetButtonUp(triggerName)) // Check if the hands trigger button has been released
        {
            heldObject.transform.SetParent(null); // Unparent food from the hand; otherwise, it will follow the hand even on the ground.
            heldObject.useGravity = true; // Restore gravity; otherwise, food will float in space.
            heldObject.isKinematic = false; // We want our food to interact "normally" with external forces of objects.
            heldObject.AddForce(transform.forward * throwImpulse); // Apply a force to the food object to throw it

        }
    }
}
