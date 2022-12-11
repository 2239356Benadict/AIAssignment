using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeAsChildOnTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "PickablePoint")
        {
            gameObject.transform.parent = other.gameObject.transform;
            gameObject.transform.position = other.gameObject.transform.position;
            
        }
    }
}
