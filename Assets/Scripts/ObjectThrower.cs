using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectThrower : MonoBehaviour
{
    public string triggerName;
    public GameObject[] objects;

    // Start is called before the first frame update
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
            GameObject random = objects[Random.Range(0, objects.Length)];
        }

        // Check if the hands trigger button has been released
        if (Input.GetButtonUp(triggerName))
        {
        }

    }
}
