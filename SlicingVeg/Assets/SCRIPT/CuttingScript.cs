using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuttingScript : MonoBehaviour
{
    
    public bool isCutting = false;
    void Start()
    {

    }
    void Update()
    {
        isCutting = Input.GetKeyDown(KeyCode.Space);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Parts") )
        {
            
            if (Input.GetKey(KeyCode.Space))
            {
                Vegitables vegPart = other.GetComponent<Vegitables>();

                if (vegPart != null)
                {
                    vegPart.Cutted();
                }
            }
            else
            {
                Debug.Log("Not cutting");
            }
        }
    }
}
