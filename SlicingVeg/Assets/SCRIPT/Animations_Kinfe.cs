using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animations_Kinfe : MonoBehaviour
{
    public Animator kc;
    public Collider DragCollider;
    // Start is called before the first frame update
    void Start()
    {
        kc = GetComponent<Animator>();
        DragCollider.enabled = false;
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
        if (Input.GetKeyDown(KeyCode.X))
        {
            DragCollider.enabled = true;
        }
        if (Input.GetKeyUp(KeyCode.X))
        {
            DragCollider.enabled = false;
        }
    }
    public void StartCut()
    {
        
    }
}
