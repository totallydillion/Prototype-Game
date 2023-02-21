using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OnGround : MonoBehaviour
{
    /// <summary>
    /// this script handles rotating on ground
    /// as well as displaying a UI for pick up when the player is in close proximinity
    /// </summary>

    public Transform Player;

    public GameObject CollectingItemUI;
    public RawImage CollectingItemPhotoUI;
    public Text CollectingItemTextUI;
    public Text CollectingItemDescriptionUI;

    PlayerProperties playerProperties;
    ItemProperties properties;
    ItemFunctions functions;

    // Start is called before the first frame update
    void Start()
    {
        properties = gameObject.GetComponent<ItemProperties>();
        playerProperties = Player.GetComponent<PlayerProperties>();
    }

    void Update()
    {
        //if the item is on the ground, then rotate it around
        if (properties.onGround)
            transform.Rotate(new Vector3(Random.Range(0, 90) * Time.deltaTime, Random.Range(0, 90) * Time.deltaTime));


        if(Vector3.Distance(transform.position, Player.transform.position) <= playerProperties.Radius)
        {
            //if the player is in range

            //display ui
            CollectingItemUI.SetActive(true);
            CollectingItemTextUI.text = properties.name;
            CollectingItemDescriptionUI.text = properties.Description;


            //collecting
            if(Input.GetKeyDown(KeyCode.E))
            {
                //collecting item
                functions.CollectItem(gameObject);
            }
        }


        else if(Vector3.Distance(transform.position, Player.transform.position) > playerProperties.Radius && CollectingItemUI.activeInHierarchy == true)
        {
            //if the user is too far away, disable the UI.
            CollectingItemUI.SetActive(false);
        }
        
    }
}
