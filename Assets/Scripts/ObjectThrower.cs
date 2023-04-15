using UnityEngine;
public class ObjectThrower : MonoBehaviour
{
    public string triggerName;  
    public Rigidbody[] objects; 
    public float throwImpulse;  
    private Rigidbody heldObject; 

    void Update()
    {    
        if (Input.GetButtonDown(triggerName))
        {
            Rigidbody randomObject = objects[Random.Range(0, objects.Length)]; 
            heldObject = Instantiate(randomObject, transform.position, transform.rotation, transform);         
            heldObject.useGravity = false;     
            heldObject.isKinematic = true;
        }

        if (Input.GetButtonUp(triggerName)) 
        {
            heldObject.transform.SetParent(null); 
            heldObject.useGravity = true; 
            heldObject.isKinematic = false; 
            heldObject.AddForce(transform.forward * throwImpulse); 
        }
    } 
}