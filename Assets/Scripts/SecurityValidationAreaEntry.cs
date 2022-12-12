// Tested in unity editor and Oculus Quest
// Copyright (c) 2239356@swanseauniversity. All rights reserved.
// Dated: 12/12/2020
// This script is used to pullback the seat and NPC once the player approaches.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecurityValidationAreaEntry : MonoBehaviour
{
    public float pullBackValue;
    public Animator avatarAnimator;
    public IDPlaced iDOnScanner;
    public Transform[] pullBackObjects;
    public bool turnedToPlayer;
    public AudioSource typeWriting;

    private void OnTriggerEnter(Collider other)
    {
        
        if (other.tag == "Player")
        {
            turnedToPlayer = true;
            if (turnedToPlayer)
            {
                foreach (Transform obj in pullBackObjects)
                {
                    obj.transform.Translate(new Vector3(0.01f, 0f, pullBackValue));
                    obj.transform.Rotate(new Vector3(0f, -95f, 0f), Space.Self);
                    Debug.Log("Player entered security check area.");
                    avatarAnimator.Play("Type To Sit");
                    typeWriting.Stop();
                }
            } 
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if(other.tag == "Player")
        {
            turnedToPlayer = false;
            foreach (Transform obj in pullBackObjects)
            {
                obj.transform.Translate(new Vector3(0f, 0f, 0f));
                obj.transform.Rotate(new Vector3(0f, 95f, 0f), Space.Self);
                Debug.Log("Player entered security check area.");
                avatarAnimator.Play("SittingAndTyping");
                typeWriting.Play();
            }
        }
    }

}
