using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LRTriggerScript : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        print(other.gameObject.name + " has entered " + gameObject.name);
    }

    void OnTriggerStay(Collider other)
    {
        print(other.gameObject.name + " is still in " + gameObject.name);
    }

    void OnTriggerExit(Collider other)
    {
        print(other.gameObject.name + " has left " + gameObject.name);
    }
}