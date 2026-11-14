using System.Collections;
using UnityEngine;
public class Enemy : MonoBehaviour
{
    public int enemyHealth = 50;
    public GameObject enemy;
    public GameObject lastWordsUI;

    private bool isLastWordsUI = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }
    // Update is called once per frame
    void Update()
    {
        Death();
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Sword"))
        {
            enemyHealth -= 10;
        }

        if (other.CompareTag("ManaOrb"))
        {
            enemyHealth -= 15;
        }

        if(other.CompareTag("Bullet"))
        {
            enemyHealth -= 10;
        }
    }
    void Death()
    {
        if (enemyHealth <= 0 && isLastWordsUI == false)
        {
            StartCoroutine(BeforeDeath());
            Destroy(gameObject);
        }
    }
    IEnumerator BeforeDeath()
    {
        
        enemy.SetActive(false);
        lastWordsUI.SetActive(true);
        yield return new WaitForSeconds(1f);
        lastWordsUI.SetActive(false);
    }
}
