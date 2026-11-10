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

