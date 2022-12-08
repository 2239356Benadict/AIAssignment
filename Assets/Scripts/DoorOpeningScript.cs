using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpeningScript : MonoBehaviour
{
    public AudioSource doorAudioSource;
    public AudioClip[] doorAudioClip;

    public GameObject door;
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "IDCard")
        {
            StartCoroutine(CardDetectedSuccessful(0.5f));
        }
        else
        {
            doorAudioSource.clip = doorAudioClip[2];

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
        door.transform.Rotate(new Vector3(0f,90f,0f));
       
    }

    void Update()
    {
        
    }


    public void DoorOpen()
    {
        
    }
}
