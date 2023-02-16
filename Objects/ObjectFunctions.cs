using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectFunctions : MonoBehaviour
{
    ObjectProperties properties;
    
    
    void Start()
    {
    // assign properties on the start
        properties = gameObject.GetComponent<ObjectProperties>();
    }

    public void DeductHealth(int amount)
    {
    // called when deducting health
    
        properties.currentHealth -= amount;
        Debug.Log(properties.currentHealth + " | " + properties.startingHealth);

        if (properties.currentHealth <= 0) // if the health is less than or equal to zero, destroy object
            DestroyObject();
            
        return;
    }

    public void DestroyObject()
    { // called when the object is destroyed 
        Destroy(gameObject);
        
        //todo ; drop something
    }
}
