using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExoPlayerInteraction : MonoBehaviour
{
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
}
