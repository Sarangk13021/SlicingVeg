using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class SpwaningScript : MonoBehaviour
{
    public GameObject Carrot;
    public GameObject Cucumber;
    public GameObject CarrotSpwanPoint;
    public GameObject CucumberSpwanPoint;
    void Start()
    {

    }

    void Update()
    {

    }
    public void CarrotButton()
    {
        // Force horizontal rotation (laying down)
        Quaternion horizontalRotation = Quaternion.Euler(90, 90, 0);
        Instantiate(Carrot, CarrotSpwanPoint.transform.position, horizontalRotation);
        EventSystem.current.SetSelectedGameObject(null);
    }

    public void CucumberButton()
    {
        // Force horizontal rotation (laying down)
        Quaternion horizontalRotation = Quaternion.Euler(0, 90, 0);
        Instantiate(Cucumber, CucumberSpwanPoint.transform.position, horizontalRotation);
        EventSystem.current.SetSelectedGameObject(null);
    }
}
