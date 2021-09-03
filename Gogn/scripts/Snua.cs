using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snua : MonoBehaviour
{
    void Update()
    {
        transform.Rotate(new Vector3(0,80,0) * Time.deltaTime); //snýr peningnum um ákveðið gildi (80) endalaust
    }
}

