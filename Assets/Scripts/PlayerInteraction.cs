using System.Collections;
using UnityEngine;

namespace Assets.Scripts
{
    public class PlayerInteraction : MonoBehaviour
    {
        public Animator npcAnimator;
        public Animation npcAnimationclips;
        private void OnTriggerEnter(Collider other)
        {
            if(other.gameObject.tag == "Player")
            {

            }
        }
    }
}