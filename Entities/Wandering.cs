using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wandering : MonoBehaviour
{
    EntityProperties properties;

    bool isWalking, isWandering, isRotatingLeft, isRotatingRight;

    void Start()
    {
        properties = gameObject.GetComponent<EntityProperties>();

        StartCoroutine(StartWandering());
    }

    void Update()
    {

        //if the entity is not wandering, start the wandering process
        if (!isWandering)
            StartCoroutine(StartWandering());

        // if the entity is supposed to be walking, walk
        if (isWalking == true)
            transform.position += transform.forward * properties.speed * Time.deltaTime;

        //is the entity turning left?
        if (isRotatingLeft)
            transform.Rotate(new Vector3(0, 1, 0) * Time.deltaTime * -properties.rotationSpeed);

        //is the entity turning right ?
        else if (isRotatingRight)
            transform.Rotate(new Vector3(0, 1, 0) * Time.deltaTime * properties.rotationSpeed);
    }


    /// <summary>
    /// this is to set all of the variables when wandering, such as "how much should be rotated", "how much to move", etc
    /// </summary>
    /// <returns></returns>
    IEnumerator StartWandering()
    {
        int rotationTime = Random.Range(1, 3);
        int rotationWait = Random.Range(1, 4);
        int rotateDirection = Random.Range(1, 2);
        int walkingWait = Random.Range(1, 4);
        int walkTime = Random.Range(1, 5);

        isWandering = true;

        yield return new WaitForSeconds(walkingWait);
        isWalking = true;
        yield return new WaitForSeconds(walkTime);
        isWalking = false;
        yield return new WaitForSeconds(rotationWait);
        if (rotateDirection == 1)
        {
            isRotatingLeft = true;
            yield return new WaitForSeconds(rotationTime);
            isRotatingLeft = false;
        }
        else
        {
            isRotatingRight = true;
            yield return new WaitForSeconds(rotationTime);
            isRotatingRight = false;
        }
        isWandering = false;

    }
}
