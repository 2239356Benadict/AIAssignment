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

        private void Start()
        {
            playerObject = GameObject.FindGameObjectWithTag("Player");
        }

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
                }
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
    }
}