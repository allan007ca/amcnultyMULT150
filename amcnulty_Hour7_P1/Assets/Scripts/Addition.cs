using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Addition : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // 1. Declare 4 int variables
        int a;
        int b;
        int c;
        int sum;

        // 2. Assign values
        a = 2;
        b = 4;
        c = 8;

        // 3. Add a, b, and c together and assign to sum
        sum = a + b + c;

        // 4. Increase sum by 1 using the increment operator
        sum++;   // This is the same as: sum = sum + 1;

        // 5. Print the final value of sum to the Console
        print(sum);
        // You could also use: Debug.Log(sum);
    }

    // Update is called once per frame (leave empty for this exercise)
    void Update()
    {
        
    }
}