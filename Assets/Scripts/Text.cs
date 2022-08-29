using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Text : MonoBehaviour
{
    public CubeObject cube;
    public TMP_Text randomNumText;


    // Get component
    private void Awake()
    {
        CubeObject cube = gameObject.GetComponent<CubeObject>();
    }

    // Call method
    void Start()
    {
        SetAndDisplayRandomNumber();
    }

    // ABSTRACTION
    void SetAndDisplayRandomNumber()
    {
        float randomNumber = Random.Range(-8, 8);
        cube.CubeNumber = randomNumber;
        randomNumText.text = "The random number is " + randomNumber + ". Check the Console for more info.";
    }
}
