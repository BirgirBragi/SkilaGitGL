using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Threading;


public class scripttt2 : MonoBehaviour
{
    public void onClick2() //fer í gang þegar notandi ýtir á takka
    {
        SceneManager.LoadScene("game"); //fer yfir í borð 1 og byrjar með því leikinn
    }
}
