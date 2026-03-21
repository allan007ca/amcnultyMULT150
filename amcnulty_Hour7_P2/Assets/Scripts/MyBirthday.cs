using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyBirthday : MonoBehaviour
{
    void Start()
    {
        int birthdayDay = 15;         //My birthday is October 15th!
        int daysInMonth = 31;         

        for (int day = 1; day <= daysInMonth; day++)
        {
            if (day == birthdayDay)
            {
                print("Its my birthday!");
            }
            else
            {
                print(day);
            }
        }
    }
}