// Tested in unity editor and Oculus Quest
// Copyright (c) 2239356@swanseauniversity. All rights reserved.
// Dated: 12/12/2020
// This script is used to NPC look at player.
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExoPlayerInteraction : MonoBehaviour
{
    public Transform initialPosition;
    public GameObject playerObject;

    private void Start()
    {
        playerObject = GameObject.FindGameObjectWithTag("Player");
    }

    /// <summary>
    /// NPC look at player
    /// </summary>
    /// <param name="other"></param>
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            gameObject.transform.LookAt(playerObject.transform);
            Debug.Log("Met player");
        }
    }

    /// <summary>
    /// NPC look back to initial place
    /// </summary>
    /// <param name="other"></param>
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            gameObject.transform.LookAt(initialPosition.position);
            Debug.Log("Met player");
        }
    }
}
