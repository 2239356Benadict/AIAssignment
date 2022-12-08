// Tested in unity editor and Oculus Quest
// Copyright (c) 2239356@swanseauniversity. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.
// Dated: 05/12/2020
// Script to get controllor button press state.
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class HandController : MonoBehaviour
{
    public ActionBasedController handController;

    public HandScript handScript;

    // Start is called before the first frame update
    void Start()
    {
        handController = GetComponent<ActionBasedController>();    
    }

    // Update is called once per frame
    void Update()
    {
        
        handScript.SetGrip(handController.selectAction.action.ReadValue<float>());     
        handScript.SetTrigger(handController.activateAction.action.ReadValue<float>());
        
    }
}
