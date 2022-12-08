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
        //RotateAroundAnObject();
    }

    //private void RotateAroundAnObject()
    //{
    //    foreach(GameObject obj in revolvingObjects)
    //    {
    //        rotateSpeed = Random.Range(10, 20);
    //        obj.transform.RotateAround(pivotGameObject.transform.position, new Vector3(0, 1, 0), rotateSpeed * Time.deltaTime);
    //    }
    //}
}
