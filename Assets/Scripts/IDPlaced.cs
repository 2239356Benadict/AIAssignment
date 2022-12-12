using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IDPlaced : MonoBehaviour
{
    public bool iDPlaced;
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "IDCard")
        {
          
            iDPlaced = true;
        }
    }
}
