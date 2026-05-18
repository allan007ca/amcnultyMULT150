using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectControl : MonoBehaviour
{
    private Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {

        anim.SetFloat("W", 0);
        anim.SetFloat("A", 0);
        anim.SetFloat("S", 0);
        anim.SetFloat("D", 0);

        if (Input.GetKey(KeyCode.W)) anim.SetFloat("W", 1);
        if (Input.GetKey(KeyCode.A)) anim.SetFloat("A", 1);
        if (Input.GetKey(KeyCode.S)) anim.SetFloat("S", 1);
        if (Input.GetKey(KeyCode.D)) anim.SetFloat("D", 1);
    }
}