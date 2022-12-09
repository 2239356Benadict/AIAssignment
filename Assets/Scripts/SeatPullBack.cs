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
