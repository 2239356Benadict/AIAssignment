// Tested in unity editor and Oculus Quest
// Copyright (c) 2239356@swanseauniversity. All rights reserved.
// Dated: 12/12/2020
// This script is used for NPC to interact with player.

using System.Collections;
using UnityEngine;
using Yarn.Unity;

namespace Assets.Scripts
{
    public class PlayerInteraction : MonoBehaviour
    {
        public Animator npcAnimator;

        public float walkingSpeed;

        public GameObject playerObject;
        public GameObject initialPositionGameObject;
        public BoxCollider triggerCollider;

        private void Start()
        {
            playerObject = GameObject.FindGameObjectWithTag("Player");
            triggerCollider = gameObject.GetComponent<BoxCollider>();
        }

        /// <summary>
        /// Calculating distance to player on trigger enter and NPC walk towards player
        /// </summary>
        /// <param name="other"></param>
        private void OnTriggerEnter(Collider other)
        {
            if(other.gameObject.tag == "Player")
            {
                float dist = Vector3.Distance(other.gameObject.transform.position, gameObject.transform.position);
                Debug.Log(dist);
                if(dist > 0.5f)
                {
                    //gameObject.transform.LookAt(other.transform);
                    ApproachPlayer();
                    
                }
                else if (dist <= 0.5f)
                {
                    npcAnimator.Play("Idle");
                    triggerCollider.isTrigger = false;
                }

            }
        }

        /// <summary>
        /// NPC walks back to the initial position.
        /// </summary>
        /// <param name="other"></param>
        public void OnTriggerExit(Collider other)
        {
            if(other.gameObject.tag == "Player")
            {
                StartCoroutine("WalkBakToPlace");
            }
        }

        /// <summary>
        /// NPC approaches player
        /// </summary>
        public void ApproachPlayer()
        {
            npcAnimator.Play("Walking");
            gameObject.transform.Translate(Vector3.forward * walkingSpeed);
        }

        IEnumerator WalkBakToPlace()
        {
            npcAnimator.Play("Left Turn");
            yield return new WaitForSeconds(1.5f);
            npcAnimator.Play("Walking");
            gameObject.transform.position = Vector3.MoveTowards(gameObject.transform.position,initialPositionGameObject.transform.position, walkingSpeed);
            yield return new WaitForSeconds(1.5f);
            gameObject.transform.position = initialPositionGameObject.transform.position;
            gameObject.transform.rotation = initialPositionGameObject.transform.rotation;
            npcAnimator.Play("Left Turn");
        }
    }
}