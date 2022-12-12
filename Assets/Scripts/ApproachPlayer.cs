using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ApproachPlayer : MonoBehaviour
{
    public Animator npcAnimator;
    public float waitingTime;
    private void OnTriggerEnter(Collider other)
    {
        
    }

    IEnumerator WalkTowardsPlayer(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        npcAnimator.Play("Walking");
    }
}
