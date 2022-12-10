﻿using System.Collections;
using UnityEngine;
using Yarn.Unity;

namespace Assets.Scripts
{
    public class PlayerInteraction : MonoBehaviour
    {
        public Animator npcAnimator;
        public Animation npcAnimationclips;
        public float walkingSpeed;

        public AudioClip[] interactionAudio;

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
                if(dist > 0.5f)
                {
                    gameObject.transform.LookAt(other.transform);
                    ApproachPlayer();
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