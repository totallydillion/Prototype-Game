using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectProperties : MonoBehaviour
{
    /// <summary>
    /// this script should be assigned to any object that is harvestable 
    /// 
    /// this script does not include the actual harvesting of the object
    /// this script does include the information of the object that is being harvested
    /// </summary>
    /// 

    public string Name; // the name of the item
    public string Tooltip; // a summary of the item
    public string Description; // a longer version of the summary of the item
    public Sprite Icon; // icon that is used for inventory
    public int StackAmount; // how many can be held at once

    public int maxHealth; //the maximum amount of health that the item can have (this is mostly for breaking things)
    public int currentHealth; //the current health that the item has, when reaches zero, the item should* be destroyed
}
