using UnityEngine;

public class TriggerWithAnimator : MonoBehaviour
{
    // Reference to the Animator component
    public Animator playAnimator;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && playAnimator != null)
        {
            Debug.Log("Player entered trigger - Enabling Animator.");
            playAnimator.enabled = true; // Enable the Animator
        }
    }
}
