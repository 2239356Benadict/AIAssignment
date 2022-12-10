using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Yarn.Unity;


public class YarnCommandScript : MonoBehaviour
{
    public Material red, green, blue;

    public GameObject cube;

    public InMemoryVariableStorage yarnInMemoryStorage;

    public TMP_Text feedbackText;



    // Start is called before the first frame update
    void Start()
    {
        feedbackText.text = "";

        cube.GetComponent<MeshRenderer>().material = green;
    }
   

    [YarnCommand("materialSelector")]
    public void MaterialSelector()
    {
        string colourTo;
        yarnInMemoryStorage.TryGetValue("$colourto", out colourTo);
        Debug.Log(colourTo);
        if(colourTo == "Red")
        {
            cube.GetComponent<MeshRenderer>().material = red;
        }
    }
}
