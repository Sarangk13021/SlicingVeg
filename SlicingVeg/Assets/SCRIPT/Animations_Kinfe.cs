using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animations_Kinfe : MonoBehaviour
{
    public Animator kc;
    public bool isCutting;
    // Start is called before the first frame update
    void Start()
    {
        kc = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            kc.SetBool("Cut", true);
        }
        else
        {
            kc.SetBool("Cut", false);
        }
    }
    public void StartCut()
    {
        
    }
}
