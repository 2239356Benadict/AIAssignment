// Tested in unity editor and Oculus Quest
// Copyright (c) 2239356@swanseauniversity. All rights reserved.
// Dated: 12/12/2020
// This script is used to pullback the seat and NPC once the player approaches.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeatPullBack : MonoBehaviour
{
    public float pullBackValue;
    private void OnTriggerStay(Collider other)
    {
        if(other.tag == "Player")
        {
            gameObject.transform.Translate(new Vector3(0f, pullBackValue, 0f));
            gameObject.transform.Rotate(new Vector3(0f, 60f, 0f));
        }
    }
}
