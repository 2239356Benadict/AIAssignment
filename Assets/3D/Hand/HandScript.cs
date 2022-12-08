// Tested in unity editor and Oculus Quest
// Copyright (c) 2239356@swanseauniversity. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.
// Dated: 05/12/2020
// Script for XR Origin hand animation.
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandScript : MonoBehaviour
{
    public Animator handAnimator;
    public string animParamenterNameGrip = "Grip";
    public string animParamenterNameTrigger = "Trigger";

    private float gripTarget;
    private float currentGripValue;
    private float triggerTarget;
    private float currentTriggerValue;
    public float speed;

    public bool triggerButtonPressed;

    // Start is called before the first frame update
    void Start()
    {
        triggerButtonPressed = false;
    }

    // Update is called once per frame
    void Update()
    {
        AnimateHand();
    }

    #region Private Methods
    /// <summary>
    /// Method for animation of hand by getting button press values.
    /// </summary>
    private void AnimateHand()
    {
        if(currentGripValue != gripTarget)
        { 
            currentGripValue = Mathf.MoveTowards(currentGripValue, gripTarget, Time.deltaTime * speed);
            handAnimator.SetFloat(animParamenterNameGrip, currentGripValue);
            //Debug.Log("Grip");
        }
        if(currentTriggerValue != triggerTarget)
        { 
            currentTriggerValue = Mathf.MoveTowards(currentTriggerValue, triggerTarget, Time.deltaTime * speed);
            handAnimator.SetFloat(animParamenterNameTrigger, currentTriggerValue);
            //Debug.Log("Trigger");
        }
    }

    public void SetGrip(float pressvalue)
    {
        gripTarget = pressvalue;
    } 
    
    public void SetTrigger(float pressvalue)
    {
        triggerTarget = pressvalue;
        if(pressvalue != 0f)
        {

            triggerButtonPressed = true;
        }
        else
        {
            triggerButtonPressed = false;
        }
    }
    #endregion
}
