// Tested in unity editor and Oculus Quest
// Copyright (c) 2239356@swanseauniversity. All rights reserved.
// Dated: 12/12/2020
// This script is used to move the Space ship inside the High security room to left and right.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShipControllorScript : MonoBehaviour
{
 
    public float speed = 5.0f;  // Speed at which the game object will move

    /// <summary>
    /// Method to move the SpaceShip to left.
    /// </summary>
    public void SpaceShipMoveLeft()
    {
        Vector3 currentPosition = transform.position;
        currentPosition.z -= speed * Time.deltaTime;
        // Update the position of the game object
        transform.position = currentPosition;
    }

    /// <summary>
    /// Method to move the SpaceShip to right.
    /// </summary>
    public void SpaceShipMoveRight()
    {
        Vector3 currentPosition = transform.position;
        currentPosition.z += speed * Time.deltaTime;
        // Update the position of the game object
        transform.position = currentPosition;
    }



}
