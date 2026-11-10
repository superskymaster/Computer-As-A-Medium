# Week 11
## Cole Adams did Health Pack and Trap
## Nicolas Salazar did Mana
## Below are the edited/newly created scripts

### Health Pack Script
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

### Trap Script
using UnityEngine;

public class Trap : MonoBehaviour
{
    public PlayerHealth playerHealth;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }
    public GameObject objectToAppear;
    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            // Makes the hidden object appear
            objectToAppear.SetActive(true);

            playerHealth.health -= 8;
        }
    }
}

## Mana Scripts
### Mana for Player
using TMPro;
using UnityEngine;

public class PlayerMana : MonoBehaviour
{

    public int mana = 100;
    public TMP_Text manaText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        manaText.text = "Mana: " + mana;
    }

    // Mana Title in the came and amount
    void Update()
    {
        manaText.text = "Mana: " + mana;
    }
}

### Mana Attack
using UnityEngine;
using UnityEngine.InputSystem;
public class ManaAttack : MonoBehaviour
{
    public Animator animator;
    public PlayerMana playerMana;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        Shoot();
    }
    //Only uses 10 mana each shot
    private void Shoot()
    {
        if (Keyboard.current.eKey.wasPressedThisFrame)
        {
            if (playerMana.mana >= 10)
            {
                animator.SetTrigger("shoot");

                playerMana.mana -= 10;

                Debug.Log("Mana remaining: " + playerMana.mana);
            }
        }
        else
        {
            animator.SetBool("shoot", false);
        }
    }
}

