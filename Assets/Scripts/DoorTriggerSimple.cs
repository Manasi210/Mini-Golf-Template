using UnityEngine;

public class DoorTriggerWithAnimator : MonoBehaviour
{
    // Reference to the Animator component on the door
    public Animator doorAnimator;

    private void OnTriggerEnter(Collider other)
    {
        // Check if the object entering the trigger has the "Player" tag
        if (other.CompareTag("Player"))
        {


            // Trigger the door opening animation
            doorAnimator.Play("Door_DoorAction");
        }
    }
}
