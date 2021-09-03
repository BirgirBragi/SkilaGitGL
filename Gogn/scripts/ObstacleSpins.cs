using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpins : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0,50,0)*Time.deltaTime);//lætur hindrunina snúast endalaust um ákveðið value (50 í þessu tilfelli)
    }
}
