using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class DisplayingLookedAtObject : MonoBehaviour
{
    /// <summary>
    /// attached to a player,
    /// this creates a ui that is at the top of the screen 
    /// that will display the item being looked at,
    /// when holding tab, it will also include an additional information
    /// </summary>


    //what should be displayed
    public LayerMask mask;

    //for the player 
    public PlayerProperties player;

    //actual ui things
    public Canvas canvas;
    public Text ItemUIText;

    void Update()
    {
        if (Physics.Raycast(transform.position, transform.forward, out var hit, player.Radius, mask))
        { //if the player is close enough, enable the canvas, and change the text
            canvas.enabled = true;


            var obj = hit.collider.gameObject;

            ObjectProperties properties = obj.GetComponent<ObjectProperties>();

            ItemUIText.text = properties.Name;
            return;
        }

        else if (!Physics.Raycast(transform.position, transform.forward, out var hitting, player.Radius, mask) && canvas.enabled)
        { //if the canvas is enabled, and the player is not looking at anything, disable the canvas

            canvas.enabled = false;
            return;
        }
    }
}
