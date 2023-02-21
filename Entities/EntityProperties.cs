using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntityProperties : MonoBehaviour
{
    //name of the entity
    public string Name;

    //how much health is entity starting with
    public int startingHealth;

    // current health of the entity
    public int currentHealth;
    
    //will this entity attack?
    public bool hostile; //todo: make this into a dropdown, with passive/aggressive/passive-aggressive

    // will this entity wander?
    public bool wander; // todo: make aggressive follow the player if the player is in a radius
    
    //intervals that the entity should wander
    public float wanderingTime;

    // radius, mostly for aggressive to follow the player, and the passive to look at the player
    public int radius;

    //how fast is the entity?
    public int speed;

    //how fast does the entity rotate?
    public int rotationSpeed;

    //how hard does the entity attack?
    public int attack;

    //drops
    public GameObject[] drops;
}
