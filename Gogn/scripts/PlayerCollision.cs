using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Threading;

public class PlayerCollision : MonoBehaviour
{
    //breytur skilgreindar
    public Movement movement;
    public static int count;
    public Text countText;

    void Update()
    {
        if (transform.position.y <= -1) //ef leikmaðurinn hefur dottið af jörðinni, platforminu
        {
            Endurræsa(); //leikmaður er dauður, restart
        }

        if (SceneManager.GetActiveScene().name == "New Scene") //ef leikmaðurinn er í senunni sem heitir "New Scene"
            {
                if (transform.position.z >= 65) //ef hann er kominn á enda borðsins
                    {
                        SkiptaUmSenu();//fer yfir í næstu senu
                    }
            }

        if (SceneManager.GetActiveScene().name == "game") //ef leikmaðurinn er í senunni sem heitir "game"
            {
                if (transform.position.z >= 50) //ef hann er kominn á enda borðsins
                    {
                        SkiptaUmSenu(); //fer yfir í næstu senu
                    }
            }
    }

    void OnCollisionEnter(Collision collisionInfo) //heldur utan um það þegar leikmaðurinn collidar við eitthvað
    {
        if(collisionInfo.collider.tag == "Obstacle") //leikmaður rekst í hindrun
        {
            collisionInfo.collider.gameObject.SetActive(false); //hindrunin hverfur
            count = count-1; //leikmaður missir líf
            SetCountText(); //texti uppfærður
        }
        if(collisionInfo.collider.tag == "Coin") //leikmaður rekst í pening
        {
            collisionInfo.collider.gameObject.SetActive(false); //peningurinn hverfur
            count = count+1; //leikmaður fær líf
            SetCountText(); //texti uppfærður
        }
        if(collisionInfo.collider.tag == "Spinning Obstacle") //leikmaður rekst í hindrun sem snýst
        {
            collisionInfo.collider.gameObject.SetActive(true); //hindrunin hverfur ekki
            count = count-5; //leikmaður missir fleiri líf en venjulega
            SetCountText(); //texti uppfærður
        }
    }

    void SetCountText() //texti uppfærður
    {
        countText.text = "Stig: " + count.ToString(); //birtir breytuna sem heldur utan um lífin/stigin í textanum
        if (count <= 0) //leikmaður dauður
        {
            movement.enabled = false; //kemur í veg fyrir að playerinn geti hreyfst áfram eftir dauðan
            countText.text = "dauður " + count.ToString()+" stig"; //birtir skilaboð um að leikmaður sé dauður

            StartCoroutine(Bida()); //endurræsir borðið
            
        }
    }

    IEnumerator Bida() //bíður í eina sekúndu og endurræsir borðið
    {
        yield return new WaitForSeconds(1);
        Endurræsa();
    }

    public void Byrja()
    {
        SceneManager.LoadScene("game");
    }
    public void Endurræsa()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);//nær í senuna sem leikmaður er nú þegar í og loadar henni upp aftur, sendir leikmann á byrjunar reit
        count = 0; //endurstillir lífin hans
    }
    public void SkiptaUmSenu()
    {
        if (SceneManager.GetActiveScene().name == "game")//ef leikmaður er í fyrsta borðinu
        {
            SceneManager.LoadScene("New Scene");//næsta sena
            count = 0; //endurstillir lífin hans
        }
        if (SceneManager.GetActiveScene().name == "New Scene")//ef leikmaður er í öðru borðinu
        {
            SceneManager.LoadScene("End");//leikurinn búinn
            count = 0; //endurstillir lífin hans
        }
        
    }
    
}
