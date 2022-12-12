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

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            gameObject.transform.LookAt(playerObject.transform);
            Debug.Log("Met player");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            gameObject.transform.LookAt(initialPosition.position);
            Debug.Log("Met player");
        }
    }
}
