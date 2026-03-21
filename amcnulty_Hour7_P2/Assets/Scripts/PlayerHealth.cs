using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    void Start()
    {
        float health = 1004f;
        float poisonDamage = 125.5f;

        print(health);

        while (health > 0)
        {
            health -= poisonDamage;
            print(health);
        }

        if (health <= 0)
        {
            print("Player has been unalived!");
        }
    }

    void Update()
    {
        
    }
}