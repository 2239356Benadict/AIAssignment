// Tested in unity editor and Oculus Quest
// Copyright (c) 2239356@swanseauniversity. All rights reserved.
// Dated: 12/12/2020
// This script is used to open the door while the ID card is scanned.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpeningScript : MonoBehaviour
{
    public AudioSource doorAudioSource;
    public AudioClip[] doorAudioClip;

    public IDValidation validationScript;

    public GameObject door;

    public float automaticClosingTime;
    /// <summary>
    /// Checking whether the ID Card is collided or not.
    /// </summary>
    /// <param name="other"></param>
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "IDCard")
        {
            validationScript = other.GetComponent<IDValidation>();
            CheckCardValidationStatus();
        }
        else if (other.gameObject.tag == "Guard")
        {
            doorAudioSource.clip = doorAudioClip[1];
            doorAudioSource.Play();
            door.transform.Rotate(new Vector3(0f, 90f, 0f));
            Debug.Log("Guard Entered");
        }
        else
        {
            doorAudioSource.clip = doorAudioClip[2];
        }
    }

    /// <summary>
    /// This method is used to check the door tag and and validation status of the ID Card. 
    /// </summary>
    private void CheckCardValidationStatus()
    {
        if (gameObject.tag == "Door")
        {
            if (validationScript.isValidated)
            {
                StartCoroutine(CardDetectedSuccessful(0.5f));
            }
            else
            {
                doorAudioSource.clip = doorAudioClip[2];
            }
        }
        else if (gameObject.tag == "Security Door")
        {
            if (validationScript.isValidated && validationScript.isSecurityValidated)
            {
                StartCoroutine(CardDetectedSuccessful(0.5f));
            }
            else
            {
                doorAudioSource.clip = doorAudioClip[2];
            }
        }
        
    }

    /// <summary>
    /// Card detected and door opening audio play, and door opens with a delay.
    /// </summary>
    /// <param name="waitingTime"></param>
    /// <returns></returns>
    private IEnumerator CardDetectedSuccessful(float waitingTime)
    { 
        doorAudioSource.clip = doorAudioClip[0];
        doorAudioSource.Play();

        yield return new WaitForSeconds(waitingTime);
        doorAudioSource.clip = doorAudioClip[1];
        doorAudioSource.Play();
        door.transform.Rotate(new Vector3(0f, 90f, 0f));

        yield return new WaitForSeconds(automaticClosingTime);
        door.transform.Rotate(new Vector3(0f, 0f, 0f));
    }

}
