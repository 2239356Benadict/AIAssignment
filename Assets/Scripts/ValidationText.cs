using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ValidationText : MonoBehaviour
{
    public TextMesh validationText;
    private IDValidation validationOutputText;


    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "IDCard")
        {
            validationOutputText = other.GetComponent<IDValidation>();
            if (validationOutputText.isValidated)
            {
                validationText.text = "Validated";
            }
        }
    }
}
