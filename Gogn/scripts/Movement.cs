using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Threading;

public class Movement : MonoBehaviour
{
    //breytur skilgreindar
    public float hradi = 2;
    public float hlidar = 2;
    public float hopp = 2;
    public Rigidbody rb;

    // Update is called once per frame
    void FixedUpdate()
    {
        if(Input.GetKey(KeyCode.UpArrow))//áfram
        {
            transform.position += transform.forward*hradi;
        }
        if(Input.GetKey(KeyCode.DownArrow))//aftur á bak
        {
            transform.position -= transform.forward*hradi;
        }
        if(Input.GetKey(KeyCode.LeftArrow))//vinstri
        {
            transform.position -= transform.right*hradi;
        }
        if(Input.GetKey(KeyCode.RightArrow))//hægri
        {
            transform.position += transform.right*hradi;
        }
        if(Input.GetKey(KeyCode.Space))//hopp
        {
            transform.position += transform.up*hopp;
        }
        if(Input.GetKey("f"))//snúa sér
        {
            transform.Rotate(new Vector3(0,5,0));
        }
        if(Input.GetKey("g"))//snúa sér
        {
            transform.Rotate(new Vector3(0,-5,0));
        }
    }


    IEnumerator Bida() //fer í gang þegar leikmaður deyr og þörf er á að endurræsa leikinn, beðið er í eina sekúndu áður en það er gert
    {
        yield return new WaitForSeconds(1);
        Endurræsa();
    }

    public void Endurræsa() //fer í gang þegar leikmaður deyr og þörf er á að endurræsa leikinn,
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);//tekur senuna sem leikmaður er í og færir hann á byrjunarreit
    }
}
