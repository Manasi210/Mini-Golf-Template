using UnityEngine;

public class TriggerAnimationOnEnter : MonoBehaviour
{
    // Reference to the Animator component of the object to animate
    public Animator targetAnimator;

    // The name of the animation state to play
    public string animationStateName;

    private void OnTriggerEnter(Collider other)
    {
        // Check if the object entering the trigger has the "Player" tag
        if (other.CompareTag("Player"))
        {
            // Play the specified animation on the target Animator
            if (targetAnimator != null && !string.IsNullOrEmpty(animationStateName))
            {
                targetAnimator.Play(animationStateName); // Plays the given animation state
                Debug.Log($"Animation {animationStateName} triggered on {targetAnimator.gameObject.name}");
            }
            else
            {
                Debug.LogWarning("Target Animator or Animation State Name is not set.");
            }
        }
    }
}
