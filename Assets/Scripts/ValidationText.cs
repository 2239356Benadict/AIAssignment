// Tested in unity editor and Oculus Quest
// Copyright (c) 2239356@swanseauniversity. All rights reserved.
// Dated: 12/12/2020
// This script is used to update the ID card validation status text.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ValidationText : MonoBehaviour
{
    public TextMeshProUGUI validationText;
    private IDValidation validationOutputText;

    /// <summary>
    /// Update the text on monitor
    /// </summary>
    /// <param name="other"></param>
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "IDCard")
        {
            validationText.text = "Please hold the ID Card until validated text appears.";
            validationOutputText = other.GetComponent<IDValidation>();
            if (validationOutputText.isValidated)
            {
                validationText.text = "Validated";
            }
        }
    }
}
