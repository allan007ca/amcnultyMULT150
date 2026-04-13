using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    int healthpoints = 3992;

    void Start()
    {
        healthpoints = UsePotion(healthpoints);
        print(healthpoints);

        healthpoints = UsePotion(healthpoints);
        print(healthpoints);

        healthpoints = UsePotion(healthpoints);
        print(healthpoints);

        healthpoints = UsePotion(healthpoints);
        print(healthpoints);

    }

    int UsePotion(int health)
    {
        return health + 400;
    }
}
