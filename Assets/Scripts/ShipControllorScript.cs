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

    public float speed = 5.0f;  // Speed at which the game object will move

    public void SpaceShipMoveLeft()
    {
        Vector3 currentPosition = transform.position;
        currentPosition.z -= speed * Time.deltaTime;
        // Update the position of the game object
        transform.position = currentPosition;
    }

    public void SpaceShipMoveRight()
    {
        Vector3 currentPosition = transform.position;
        currentPosition.z += speed * Time.deltaTime;
        // Update the position of the game object
        transform.position = currentPosition;
    }



}
