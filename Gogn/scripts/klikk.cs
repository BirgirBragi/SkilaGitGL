using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Threading;


public class klikk : MonoBehaviour
{
    void onClick() //þetta fer í gang þegar smellt er á takkann í lokasenunni
    {
        SceneManager.LoadScene("Start"); //tekur notandann aftur á byrjunarsenuna
    }
}
