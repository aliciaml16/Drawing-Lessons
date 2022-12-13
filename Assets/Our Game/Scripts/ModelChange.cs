using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModelChange : MonoBehaviour
{
    public GameObject[] steps;
    public GameObject[] positionSteps;
    private GameObject clone01;
    private GameObject clone02;
    private GameObject clone00;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    void OnEnable()
    {
        clone00 = Instantiate(steps[0], positionSteps[0].transform.position, Quaternion.Euler(0f, 0f, 0f));
        clone00.transform.parent = positionSteps[0].transform;
        clone01 = Instantiate(steps[1], positionSteps[1].transform.position, Quaternion.Euler(0f, 0f, 0f));
        clone01.transform.parent = positionSteps[1].transform;
        clone02 = Instantiate(steps[2], positionSteps[2].transform.position, Quaternion.Euler(0f, 0f, 0f));
        clone02.transform.parent = positionSteps[2].transform;
    }

    void OnDisable()
    {
        Destroy(clone00);
        Destroy(clone01);
        Destroy(clone02);
    }
}
