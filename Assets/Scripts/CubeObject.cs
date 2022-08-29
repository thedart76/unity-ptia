using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeObject : ParentObject
{
    private float cubeNumber;

    // ENCAPSULATION
    public float CubeNumber
    {
        get
        {
            return cubeNumber;
        }
        set
        {
            if (value < 0.0f)
            {
                Debug.LogError("Negative numbers are not allowed!");
            }
            else
            {
                cubeNumber = value;
                LogDetails(cubeNumber);
            }
        }
    }

    // INHERITANCE
    void Start()
    {
        LogDetails(ObjectName);
    }

    // POLYMORPHISM Override
    public override void LogDetails(string name)
    {
        Debug.Log("OVERRIDDEN string. The child object's name is: " + name);
    }
}
