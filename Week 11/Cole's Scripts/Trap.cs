using UnityEngine;
public class Trap : MonoBehaviour
{
    public PlayerHealth playerHealth;
    public GameObject objectToAppear;
    // Start is called once before the first execution of Update after theMonoBehaviour is created
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            //Make the hidden object appear
            objectToAppear.SetActive(true);

            playerHealth.health -= 8;
        }
    }
}