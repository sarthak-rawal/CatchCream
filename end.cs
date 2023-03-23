using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class end : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D obs)
    {
        if (obs.gameObject.tag == "Obstacle")
        {
            SceneManager.LoadScene(4);
        }
    }
    

}
