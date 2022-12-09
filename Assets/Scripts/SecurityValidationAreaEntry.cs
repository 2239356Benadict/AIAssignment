using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecurityValidationAreaEntry : MonoBehaviour
{
    public float pullBackValue;

    public Transform[] pullBackObjects;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            foreach(Transform obj in pullBackObjects)
            {
                obj.transform.Translate(new Vector3(0.01f, 0f, pullBackValue));
                obj.transform.Rotate(new Vector3(0f, -95f, 0f), Space.Self);
                Debug.Log("Player entered security check area.");
            }
            
        }
    }
}
