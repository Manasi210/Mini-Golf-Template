using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine;

using UnityEngine;

public class DoorTrigger : MonoBehaviour
{
    public Animation doorAnimation;  // Reference to the door's Animation component
    public Animator harryAnimator;   // Animator for Harry's idle animation

    private void OnTriggerEnter(Collider other)
    {
        // Check if the player entered the trigger zone
        if (other.CompareTag("Player"))
        {
            // Play the door opening animation
            if (doorAnimation != null)
            {
                doorAnimation.Play("DoorOpening"); // Name of the Animation Clip
            }

            // Play Harry's idle animation
            if (harryAnimator != null)
            {
                harryAnimator.SetTrigger("Idle");
            }

            Debug.Log("Door opened, and Harry's idle animation started!");
        }
    }
}


