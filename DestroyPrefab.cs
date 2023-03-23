using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DestroyPrefab : MonoBehaviour
{
    void Start()
    {

    }
 private void  OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Border"))
        {
            Destroy(gameObject);
        }
    }
}
