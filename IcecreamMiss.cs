using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class IcecreamMiss : MonoBehaviour
{
    public Text remchance;
    private int rcnum;
    void Start()
    {
        rcnum = 7;
        remchance.text = "Remaining Chances : " + rcnum;
    }

    // Update is called once per frame
    private void OnCollisionEnter2D(Collision2D collision)
    {
        

           if( collision.gameObject.tag == "Collect")
            {
                rcnum--;
                Destroy(collision.gameObject);
                remchance.text = "Remaining Chance : " + rcnum;
                
            }
         if(rcnum == 0)
        {
            SceneManager.LoadScene(4);
        }
        
     }
}
