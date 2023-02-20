using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerProperties : MonoBehaviour
{

    //information made clear to the player
    public int Health;
    public float Stamina;
    public int jumpHeight;

    //not for showing
    public int Radius; // how far can the player see

    //inventory
    public GameObject LeftHand;
    public GameObject RightHand;

    //backpack
    public bool hasBackpack;
    public int backpackSlots;

    //stats
    public int attackSpeed;
    public int attackPower;

}
