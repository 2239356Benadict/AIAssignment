using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShipControllorScript : MonoBehaviour
{
    public ParticleSystem destroyParticleSystem;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Enemy")
        {
            StartCoroutine("DestroyShip");
        }
    }



    IEnumerator DestroyShip(float destroyDelayTime)
    {
        destroyParticleSystem.Play();
        yield return new WaitForSeconds(destroyDelayTime);

        Destroy(gameObject);

    }
}
