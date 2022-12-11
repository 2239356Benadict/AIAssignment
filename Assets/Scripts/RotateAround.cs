// Tested in unity editor and Oculus Quest
// Copyright (c) 2239356@swanseauniversity. All rights reserved.
// Dated: 12/12/2020
// This script is used to rotate the gameobject which this script attached to around another.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAround : MonoBehaviour
{
    public GameObject pivotGameObject;

    //public GameObject[] revolvingObjects;
   
    public float rotateSpeed;
    public float rotationSpeed;
    void Update()
    {
        gameObject.transform.RotateAround(pivotGameObject.transform.position, new Vector3(0, 1, 0), rotateSpeed * Time.deltaTime);
        gameObject.transform.Rotate(new Vector3(0, 180 * rotationSpeed, 0) * Time.deltaTime);

    }

}
