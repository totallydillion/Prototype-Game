using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Harvesting : MonoBehaviour
{
    public PlayerProperties player;

    public LayerMask mask;

    public void Update()
    {
        if (Input.GetMouseButtonDown(0))
        { // when the user clicks
            if (Physics.Raycast(transform.position, transform.forward, out var hit, player.Radius, mask)){
                // if they are looking at an object

                var obj = hit.collider.gameObject;

                // hit the object
                obj.GetComponent<ObjectFunctions>().DeductHealth(player.attackPower);

            }
        }
    }
}
