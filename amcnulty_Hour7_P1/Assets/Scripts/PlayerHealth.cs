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

        health -= poisonDamage;
        print(health);

        health -= poisonDamage;
        print(health);

        health -= poisonDamage;
        print(health);

        health -= poisonDamage;
        print(health);

        health -= poisonDamage;
        print(health);

        health -= poisonDamage;
        print(health);

        health -= poisonDamage;
        print(health);

        health -= poisonDamage;
        print(health);

        print(health);
        print("Player has been unalived!");
    }
}