using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vegitables : MonoBehaviour
{
    private Rigidbody rg;
    private Collider cl;
    public bool isCut = false;
    void Start()
    {
        rg = GetComponent<Rigidbody>();
        cl = GetComponent<Collider>();
        rg.isKinematic = true;
        cl.isTrigger = true;
    }
    void Update()
    {

    }
    public void Cutted()
    {
        if (!isCut)
        {
            rg.isKinematic = false;
            cl.isTrigger = false;
        }
        
    }
}
