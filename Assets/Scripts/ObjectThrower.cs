using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectThrower : MonoBehaviour
{
    public string triggerName;
    public Rigidbody[] objects;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Check if the hands trigger button has been pressed
        if (Input.GetButtonDown(triggerName))
        {
            // Randomly choose a game object from an array to spawn
            Rigidbody randomObject = objects[Random.Range(0, objects.Length)];

            //Spawn the randomly choosen food prefab
            Rigidbody newObject = Instantiate(randomObject, transform.position, transform.rotation, transform);

            newObject.useGravity = false;

        }

        // Check if the hands trigger button has been released
        if (Input.GetButtonUp(triggerName))
        {
        }
    }
}
