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

