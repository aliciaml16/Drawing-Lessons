using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TemplateChange : MonoBehaviour
{
    public Material[] steps;
    public GameObject[] positionSteps;
    private GameObject clone00;
    private GameObject clone01;

    void Start()
    {

    }

    void Update()
    {

    }

    void OnEnable()
    {
        positionSteps[0].GetComponent<MeshRenderer>().material = steps[0];
        positionSteps[1].GetComponent<MeshRenderer>().material = steps[1];
    }
}
