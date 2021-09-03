using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Threading;

public class scripttt : MonoBehaviour
{
    public void onClick() //fer í gang þegar notandi smellir á takka
    {
        SceneManager.LoadScene("Start"); //fer með notandann aftur í byrjun leiksins
    }
}
