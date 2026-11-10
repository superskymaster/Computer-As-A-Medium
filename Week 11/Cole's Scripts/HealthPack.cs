using UnityEngine;

public class HealthPack : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        // Check if the object touching the health pack is the Player
        if (other.CompareTag("Player"))
        {
            // Get the PlayerHealth component directly from the player that touched it
            PlayerHealth playerHealth = other.GetComponent<PlayerHealth>();

            if (playerHealth != null)
            {
                // If playerhealth == 100, do nothing
                if (playerHealth.health >= 100)
                {
                    return;
                }

                // If its anything else +10
                playerHealth.health += 10;

                // Ensure health doesn't accidentally exceed 100 
                if (playerHealth.health > 100)
                {
                    playerHealth.health = 100;
                }

                // Destroy the health pack item self
                Destroy(gameObject);
            }
        }
    }
}
