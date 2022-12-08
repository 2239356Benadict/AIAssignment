using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class IDValidation : MonoBehaviour
{
    public bool isValidated;
    public bool isSecurityValidated;

    public float timeToValidate;
    public float securityValidationTime;
    
    public TextMeshProUGUI validatedID;
    public int validatedIDNumber;
    
    public Sprite[] validateStatusSprite;
    
    public Image approvedImage;
    public Image securityApprovalImage;



    private void Start()
    {
        approvedImage.sprite = validateStatusSprite[0];
        securityApprovalImage.sprite = validateStatusSprite[0];
        isValidated = false;
        isSecurityValidated = false;
        
    }



    private void OnTriggerEnter(Collider other)
    {
        if(gameObject.tag == "Validator")
        {
            StartCoroutine(ValidationRoutine());
            validatedIDNumber = Random.Range(1000, 5000);
            validatedID.text = validatedIDNumber.ToString();
        }
        else if(gameObject.tag == "Security Validator")
        {
            StartCoroutine(SecurityValidationRoutine());
        }
    }

    private IEnumerator SecurityValidationRoutine()
    {
        yield return new WaitForSeconds(securityValidationTime);
        isSecurityValidated = true;
        securityApprovalImage.sprite = validateStatusSprite[1];
    }

    private IEnumerator ValidationRoutine()
    {
        yield return new WaitForSeconds(timeToValidate);
        isValidated = true;
        approvedImage.sprite = validateStatusSprite[1];
    }
}
