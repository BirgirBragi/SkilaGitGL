using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    //breytur skilgreindar
    public Transform player;
    public Vector3 offset; 
    // Update is called once per frame
    void Update()
    {
        transform.position = player.position+offset; //cameran færð að staðsetningu leikmannsins með smá offset
    }
}
