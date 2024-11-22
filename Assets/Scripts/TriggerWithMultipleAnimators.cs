using UnityEngine;

public class TriggerWithMultipleAnimators : MonoBehaviour
{
    // Array to hold multiple Animator components
    public Animator[] animators;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player entered trigger - Enabling Animators.");

            // Loop through all animators and enable them
            foreach (Animator animator in animators)
            {
                if (animator != null)
                {
                    animator.enabled = true; // Enable each Animator
                }
            }
        }
    }
}
