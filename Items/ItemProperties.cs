using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemProperties : MonoBehaviour
{
    //basic information that is going be shown
    [Header("Basic Information")]
    public string Name;
    public string Description;
    public GameObject droppedDisplay;

    //this is for the stuff that the player can not see
    [Header("Stats")]
    public bool onGround;

    //how many hands will it take to carry this item?
    [Range(1, 2)]
    public int carryCapacity;

    //tools
    [Header("Tools")]
    public int durability;

    //weapons
    [Header("Weapons")]
    public int Damage;
    
}
