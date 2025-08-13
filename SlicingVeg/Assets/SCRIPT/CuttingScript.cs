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
            //Debug.Log("Entered");
            //Vegitables vgpart = other.GetComponent<Vegitables>();
            //if (vgpart != null)
            //{
            //    vgpart.Cutted();
            //}
            if (Input.GetKey(KeyCode.Space)) // Direct check here
            {
                Vegitables vegPart = other.GetComponent<Vegitables>();

                if (vegPart != null)
                {
                    vegPart.Cutted();
                }
            }
            else
            {
                Debug.Log("Not cutting - Space key not pressed");
            }
        }
    }
}
