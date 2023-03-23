using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Score : MonoBehaviour
{
    public Text MyScoreText;
    private int snum;
    void Start()
    {
        snum = 0;
        MyScoreText.text = "Score : " + snum;
    }
    private void OnTriggerEnter2D(Collider2D collect)
    {
        if(collect.tag == "Collect")
        {
            snum++;
            Destroy(collect.gameObject);
            MyScoreText.text = "Score : " + snum;
        }
        if (collect.tag == "Five")
        {
            snum += 5;
            Destroy(collect.gameObject);
            MyScoreText.text = "Score : " + snum;
        }
    }
    }



