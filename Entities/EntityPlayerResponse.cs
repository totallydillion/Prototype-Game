using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntityPlayerResponse : MonoBehaviour
{
    /// <summary>
    /// this script is in charge of responding to the player
    /// 
    /// ideally, passive animals will just look at the player when it is in radius
    /// alternatively, passive aggressive animals will look at, and will follow and attack when attacked
    /// lastly, aggressive animals will follow and attack when in radius
    /// </summary>
    /// 

    //at the moment the only thing that is set up, is to look at the player when they are in radius

    public Transform PlayerObject;

    EntityProperties properties;

    void Start()
    {
        properties = gameObject.GetComponent<EntityProperties>();
    }

    void FixedUpdate()
    {
        if(Vector3.Distance(transform.position, PlayerObject.transform.position) <= properties.radius)
        {
            transform.LookAt(PlayerObject);
        }
    }
}
