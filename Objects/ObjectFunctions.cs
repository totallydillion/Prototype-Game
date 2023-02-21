using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectFunctions : MonoBehaviour
{
    //todo: make it so objects are spreaded out a little bit more, as well as have a factor for rarity.

    ObjectProperties properties;

    void Start()
    {
        // assign properties on the start
        properties = gameObject.GetComponent<ObjectProperties>();
    }

    public void DeductHealth(int amount)
    {
        // called when deducting health

        // take away the amount of health
        properties.currentHealth -= amount;

        if (properties.currentHealth <= 0) // if the health is less than or equal to zero, destroy object
            DestroyObject();

        return;
    }

    public void DestroyObject()
    { // called when the object is destroyed 

        //drop the items
        for(int i = 0; i < properties.drops.Length; i++)
        {
            //for every item

            //duplicate the drop at the position of the object that was destroyed

            Instantiate(properties.drops[i], transform.position, Quaternion.identity);

        }

        //destroy the original object
        Destroy(gameObject);


    }
}
