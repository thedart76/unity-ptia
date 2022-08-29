using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParentObject : MonoBehaviour
{
    public string ObjectName;

    // Get component
    private void Awake()
    {
        ObjectName = gameObject.name;
    }

    // Call method using string parameter
    private void Start()
    {
        LogDetails(ObjectName);
    }

    // ABSTRACTION
    public virtual void LogDetails(string name)
    {
        Debug.Log("The parent empty object's name is: " + name);
    }

    // POLYMORPHISM Overload
    public virtual void LogDetails(float num)
    {
        Debug.Log("The cube accepts and prints positive numbers only, such as: " + num);
    }
}
