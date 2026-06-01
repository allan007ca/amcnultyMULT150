using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KittySpinner : MonoBehaviour
{
    public float spinSpeed = 200f;    

    void Update()
    {
        
        transform.Translate(0, 0, -20f * Time.deltaTime, Space.World);
        
        
        transform.Rotate(0, spinSpeed * Time.deltaTime, 0);
    }
}
