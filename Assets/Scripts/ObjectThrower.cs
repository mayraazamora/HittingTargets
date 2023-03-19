using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectThrower : MonoBehaviour
{
    public string triggerName;

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
            Debug.Log($"{triggerName} was pressed");
        }

        // Check if the hands trigger button has been released
        if (Input.GetButtonUp(triggerName))
        {
            Debug.Log($"{triggerName} was released");
        }

    }
}
